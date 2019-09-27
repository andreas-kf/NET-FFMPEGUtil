﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.InteropServices;

namespace FfmpegUtil
{
    public partial class Form1 : Form
    {
        string[] resolutionOptions = new string[] { "720p", "1080p", "2560x1600", "4K", "Custom" };
        string homeDirectory;
        string[] fileList;
        string timelapseFileListPrefix;
        string timelapseFileListStartIndex;
        int sourceDimX = 3000;
        int sourceDimY = 2000;
        int resX, resY;
        string fileNameResPostfix, fileNameScaleCropPostfix, fileNameZooming;


        public Form1(string[] args)
        {
            InitializeComponent();
            foreach(string resType in resolutionOptions)
            {
                comboBoxResolution.Items.Add(resType);
            }
            comboBoxResolution.SelectedIndex = 1;
            comboBoxResolution.Select();
            comboBoxScaleCrop.SelectedIndex = 0;
            comboBoxScaleCrop.Select();
            comboBoxResolution_SelectedIndexChanged(this, null); // Call this to initialize the resolution variables
            logMessage("Welcome Biatches");

            resetProject(Directory.GetCurrentDirectory());

            // Check if we should run the program in automated mode
            Boolean autoMode = false;
            if(args.Length >= 1)
            {
                autoMode = true;
                if(args[0].Equals("720p"))
                {
                    comboBoxResolution.SelectedIndex = 0;
                }
                else if (args[0].Equals("1080p"))
                {
                    comboBoxResolution.SelectedIndex = 1;
                }
                else if(args[0].Equals("2.5k"))
                {
                    comboBoxResolution.SelectedIndex = 2;
                }
                else if (args[0].Equals("4k"))
                {
                    comboBoxResolution.SelectedIndex = 3;
                }
                else
                {
                    autoMode = false;
                }
            }
            // Use dot instead of comma for float values
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            // Run automode if the argument is present
            if (autoMode)
            {
                buttonGenerateVideo_Click(this, null);
                this.Close();
                Application.Exit();
            }
        }

        public void logMessage(string message)
        {
            textBoxLog.Text = textBoxLog.Text + message + "\r\n" ;
        }

        public void resetProject(String projectDirectory)
        {
            homeDirectory = projectDirectory;
            labelFolder.Text = homeDirectory;
            fileList = Directory.GetFiles(homeDirectory);
            List<String> fileList2 = new List<string>(fileList);
            fileList2 = fileList2.OrderBy(q => q).ToList();
            fileList = fileList2.ToArray();
            decodeFileList();
            decodeFirstImageMetaData();
        }

        public FileInfo decodeFile(string file)
        {
            FileInfo currentFileInfo = new FileInfo();
            if (Path.GetExtension(file) == ".JPG")
            {
                currentFileInfo.ValidFile = true;
                currentFileInfo.FileName = Path.GetFileName(file);
                currentFileInfo.FilePrefix = currentFileInfo.FileName.Substring(0, 3);
                //currentFileInfo.FilePrefix = currentFileInfo.FileName.Split('_')[0];
                string fileIndex = currentFileInfo.FileName.Substring(3, 5);// currentFileInfo.FileName.Split(new char[]{ '_', '.'})[1];
                if(!Int32.TryParse(fileIndex, out currentFileInfo.FileIndex))
                {
                    currentFileInfo.FileIndex = 0;
                }
            }
            else currentFileInfo.ValidFile = false;
            return currentFileInfo;
        }

        public void decodeFileList()
        {
            FileInfo fileInfo = null;
            Boolean firstFileFound = false;
            Boolean lastFileFound = false;
            int numFiles = 0, prevIndex = 0;

            // Find the first valid file in the directory. 
            foreach (string file in fileList)
            {
                fileInfo = decodeFile(file);
                if (!firstFileFound)
                {
                    if (fileInfo.ValidFile)
                    {
                        firstFileFound = true;
                        numFiles++;
                        timelapseFileListStartIndex = fileInfo.FileIndex.ToString();
                        timelapseFileListPrefix = fileInfo.FilePrefix;
                        prevIndex = fileInfo.FileIndex;
                        labelStartNum.Text = fileInfo.FileIndex.ToString();
                    }
                }
                else
                {
                    if(fileInfo.ValidFile && fileInfo.FileIndex == (prevIndex + 1))
                    {
                        numFiles++;
                        prevIndex++;
                    }
                    else
                    {
                        lastFileFound = true;
                        break;
                    }
                }
            }

            labelNumFiles.Text = numFiles.ToString();
        }

        public void decodeFirstImageMetaData()
        {
            if (fileList.Length > 0)
            {
                String firstFile = fileList[0];
                FileInfo firstFileInfo = decodeFile(firstFile);
                if (firstFileInfo.ValidFile)
                {
                    Image firstImage = new Bitmap(firstFile);
                    sourceDimX = firstImage.Width;
                    sourceDimY = firstImage.Height;
                    labelResolution.Text = sourceDimX.ToString() + "x" + sourceDimY.ToString();
                    labelAspectRatio.Text = sourceDimX > sourceDimY ?
                                            ((double)sourceDimX / (double)sourceDimY).ToString("0.##") + "/1" :
                                            "1/" + ((double)sourceDimY / (double)sourceDimX).ToString("0.##");
                    pictureBoxPreview.Image = firstImage;
                    //firstImage.Dispose();
                }
            }
        }

        private void buttonGenerateVideo_Click(object sender, EventArgs e)
        {
            float sourceAspect = (float)sourceDimX / (float)sourceDimY;
            float targetAspect = (float)resX / (float)resY;
            int cropW = 0, cropH = 0, cropX = 0, cropY = 0;
            switch(comboBoxScaleCrop.SelectedIndex)
            {
                // Scale to fit within
                case 0:
                    if(targetAspect > sourceAspect)
                    {
                        resX = (int)((float)resY * sourceAspect);
                        // Make sure resolution is divisible by two
                        resX &= ~1;
                    }
                    else
                    {
                        resY = (int)((float)resX / sourceAspect);
                        // Make sure resolution is divisible by two
                        resY &= ~1;
                    }
                    fileNameScaleCropPostfix = "";
                    break;
                // Stretch to fit
                case 1:
                    fileNameScaleCropPostfix = "_s";
                    break;
                // Crop to fit
                case 2:
                    cropW = resX;
                    cropH = resY;
                    if (targetAspect > sourceAspect)
                    {
                        cropX = 0;
                        cropY = 0;
                    }
                    else
                    {
                        cropX = 0;
                        cropY = 0;
                    }
                    fileNameScaleCropPostfix = "_c";
                    break;
                // Scale to fit outside
                case 3:
                    if (targetAspect > sourceAspect)
                    {
                        resY = (int)((float)resX / sourceAspect);
                        // Make sure resolution is divisible by two
                        resY &= ~1;
                    }
                    else
                    {
                        resX = (int)((float)resY * sourceAspect);
                        // Make sure resolution is divisible by two
                        resX &= ~1;
                    }
                    fileNameScaleCropPostfix = "_o";
                    break;
                default:
                    fileNameScaleCropPostfix = "";
                    break;
            }
            string fileName = timelapseFileListPrefix + "_" + timelapseFileListStartIndex + "_interval" + fileNameResPostfix + fileNameScaleCropPostfix + ".mp4";
            string command = "ffmpeg";
            command += " -r " + numericUpDown1.Value.ToString();
            command += " -start_number " + timelapseFileListStartIndex;
            command += " -i " + "\"" + homeDirectory + "\\" + timelapseFileListPrefix + "%05d.JPG\"";
            // Change pixel format to allow importing into premiere
            command += " -pix_fmt yuv420p";
            // Video filters
            bool videoFiltersUsed = false;
            if (cropW > 0 || cropH > 0)
            {
                if (targetAspect > sourceAspect)
                {
                    command += " -vf \"crop=" + "in_w" + ":" + "in_h*" + (sourceAspect / targetAspect).ToString();
                }
                else
                {
                    command += " -vf \"crop=" + "in_w*" + (targetAspect / sourceAspect).ToString() + ":" + "in_h";
                }
                videoFiltersUsed = true;
                //command += " -filter:v \"crop = " + cropW.ToString() + ":" + cropH.ToString() + ":" + cropX.ToString() + ":" + cropY.ToString() + "\"";
            }
            // Add sharpening
            if (checkBoxSharpen.Checked)
            {
                if (!videoFiltersUsed)
                {
                    command += " -vf \"unsharp=3:3:1.5";
                    videoFiltersUsed = true;
                }
                else
                {
                    command += ",unsharp=3:3:1.5";
                }
            }

            if (videoFiltersUsed) command += "\"";
            command += " -s " + resX.ToString() + "x" + resY.ToString();
            command += " -vcodec libx264";
            command += " " + fileName;
            logMessage(command);
            ExecuteCommand(command);
        }

        public void ExecuteCommand(string Command)
        {
            ProcessStartInfo ProcessInfo;
            Process Process;

            String runMethod = checkBoxAutoClose.Checked ? "/C " : "/K ";
            ProcessInfo = new ProcessStartInfo("cmd.exe", runMethod + Command);
            ProcessInfo.CreateNoWindow = false;
            ProcessInfo.UseShellExecute = false;

            Process = Process.Start(ProcessInfo);
        }

        public void ExecuteCommandZoom(string Command)
        {
            ProcessStartInfo ProcessInfo;
            Process Process;

            String runMethod = checkBoxAutoCloseZoom.Checked ? "/C " : "/K ";
            ProcessInfo = new ProcessStartInfo("cmd.exe", runMethod + Command);
            ProcessInfo.CreateNoWindow = false;
            ProcessInfo.UseShellExecute = false;

            Process = Process.Start(ProcessInfo);
        }

        private void textBoxResX_TextChanged(object sender, EventArgs e)
        {
            if(textBoxResX.Enabled)
            {
                if(Int32.TryParse(textBoxResX.Text, out resX))
                {
                    fileNameResPostfix = "_" + resX.ToString() + "x" + resY.ToString();
                }
            }
        }

        private void textBoxResY_TextChanged(object sender, EventArgs e)
        {
            if (textBoxResY.Enabled)
            {
                if (Int32.TryParse(textBoxResY.Text, out resY))
                {
                    fileNameResPostfix = "_" + resX.ToString() + "x" + resY.ToString();
                }
            }
        }

        private void buttonGenerateFilm_Click(object sender, EventArgs e)
        {
            string command = "ffmpeg -i ";
            command += "\"" + fileNameZooming + "\"";
            command += " -vf \"zoompan=z='1+(" + zoomZ.Text + "*in/" + framesZoom.Text + ")'";
            command += ":x='" + zoomX.Text + "*in/" + framesZoom.Text + "'";
            command += ":y='" + zoomY.Text + "*in/" + framesZoom.Text + "':d=1\"";
            command += " " + textBoxOutputFileName.Text +".mp4";
            logMessage(command);
            ExecuteCommandZoom(command);
            textBoxOutputZoom.Text = "";
            textBoxOutputZoom.Text = command;
        }

        private void buttonLoadFilm_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                resetProject(folderBrowserDialog1.SelectedPath);
            }
        }

        private void framesZoom_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLoadFilm_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Movie",

                CheckFileExists = true,
                CheckPathExists = true,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                labelFilmLoaded.Text = openFileDialog1.FileName;
                fileNameZooming = openFileDialog1.FileName;
            }

        }

        private void buttonLoadDirectory_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            
            if(result == DialogResult.OK)
            {
                resetProject(folderBrowserDialog1.SelectedPath);
            }
        }

        private void comboBoxResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool customTextBoxesEnabled = false;
            switch (comboBoxResolution.SelectedIndex)
            {
                case 0:
                    resX = 1280;
                    resY = 720;
                    fileNameResPostfix = "_720p";
                    break;
                case 1:
                    resX = 1920;
                    resY = 1080;
                    fileNameResPostfix = "_1080p";
                    break;
                case 2:
                    resX = 2560;
                    resY = 1600;
                    fileNameResPostfix = "_1600p";
                    break;
                case 3:
                    resX = 3840;
                    resY = 2160;
                    fileNameResPostfix = "_4k";
                    break;
                case 4:
                    customTextBoxesEnabled = true;
                    fileNameResPostfix = "";
                    break;
                default:
                    break;
            }
            textBoxResX.Text = resX.ToString();
            textBoxResY.Text = resY.ToString();
            textBoxResX.Enabled = textBoxResY.Enabled = customTextBoxesEnabled;
        }
    }

    public class FileInfo
    {
        public Boolean ValidFile;
        public int FileIndex;
        public string FilePrefix;
        public string FileName;

    }
}
