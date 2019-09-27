namespace FfmpegUtil
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxResolution = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxSharpen = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGenerateVideo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxLog = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelStartNum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNumFiles = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxScaleCrop = new System.Windows.Forms.ComboBox();
            this.labelResolution = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelAspectRatio = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxAutoClose = new System.Windows.Forms.CheckBox();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.buttonLoadDirectory = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.labelFolder = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxResX = new System.Windows.Forms.TextBox();
            this.textBoxResY = new System.Windows.Forms.TextBox();
            this.buttonGenerateFilm = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonLoadFilm = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.zoomX = new System.Windows.Forms.TextBox();
            this.zoomY = new System.Windows.Forms.TextBox();
            this.zoomZ = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.framesZoom = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTimelapse = new System.Windows.Forms.TabPage();
            this.tabZoom = new System.Windows.Forms.TabPage();
            this.labelFilmLoaded = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxAutoCloseZoom = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxOutputFileName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxOutputZoom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabTimelapse.SuspendLayout();
            this.tabZoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxResolution
            // 
            this.comboBoxResolution.FormattingEnabled = true;
            this.comboBoxResolution.Location = new System.Drawing.Point(106, 55);
            this.comboBoxResolution.Name = "comboBoxResolution";
            this.comboBoxResolution.Size = new System.Drawing.Size(144, 24);
            this.comboBoxResolution.TabIndex = 3;
            this.comboBoxResolution.SelectedIndexChanged += new System.EventHandler(this.comboBoxResolution_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resolution";
            // 
            // checkBoxSharpen
            // 
            this.checkBoxSharpen.AutoSize = true;
            this.checkBoxSharpen.Checked = true;
            this.checkBoxSharpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSharpen.Location = new System.Drawing.Point(106, 97);
            this.checkBoxSharpen.Name = "checkBoxSharpen";
            this.checkBoxSharpen.Size = new System.Drawing.Size(18, 17);
            this.checkBoxSharpen.TabIndex = 6;
            this.checkBoxSharpen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sharpen";
            // 
            // buttonGenerateVideo
            // 
            this.buttonGenerateVideo.Location = new System.Drawing.Point(23, 486);
            this.buttonGenerateVideo.Name = "buttonGenerateVideo";
            this.buttonGenerateVideo.Size = new System.Drawing.Size(309, 36);
            this.buttonGenerateVideo.TabIndex = 10;
            this.buttonGenerateVideo.Text = "Generate Video";
            this.buttonGenerateVideo.UseVisualStyleBackColor = true;
            this.buttonGenerateVideo.Click += new System.EventHandler(this.buttonGenerateVideo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Framerate";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(106, 130);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 22);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(23, 348);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(416, 132);
            this.textBoxLog.TabIndex = 9;
            this.textBoxLog.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Start Number";
            // 
            // labelStartNum
            // 
            this.labelStartNum.AutoSize = true;
            this.labelStartNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartNum.Location = new System.Drawing.Point(140, 209);
            this.labelStartNum.Name = "labelStartNum";
            this.labelStartNum.Size = new System.Drawing.Size(0, 17);
            this.labelStartNum.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Number of files";
            // 
            // labelNumFiles
            // 
            this.labelNumFiles.AutoSize = true;
            this.labelNumFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumFiles.Location = new System.Drawing.Point(140, 232);
            this.labelNumFiles.Name = "labelNumFiles";
            this.labelNumFiles.Size = new System.Drawing.Size(0, 17);
            this.labelNumFiles.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Scale/crop";
            // 
            // comboBoxScaleCrop
            // 
            this.comboBoxScaleCrop.FormattingEnabled = true;
            this.comboBoxScaleCrop.Items.AddRange(new object[] {
            "Scale to fit within",
            "Stretch to fit",
            "Crop to fit within",
            "Scale to fit outside"});
            this.comboBoxScaleCrop.Location = new System.Drawing.Point(106, 166);
            this.comboBoxScaleCrop.Name = "comboBoxScaleCrop";
            this.comboBoxScaleCrop.Size = new System.Drawing.Size(144, 24);
            this.comboBoxScaleCrop.TabIndex = 8;
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResolution.Location = new System.Drawing.Point(140, 254);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(0, 17);
            this.labelResolution.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Resolution";
            // 
            // labelAspectRatio
            // 
            this.labelAspectRatio.AutoSize = true;
            this.labelAspectRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAspectRatio.Location = new System.Drawing.Point(140, 276);
            this.labelAspectRatio.Name = "labelAspectRatio";
            this.labelAspectRatio.Size = new System.Drawing.Size(0, 17);
            this.labelAspectRatio.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Aspect ratio";
            // 
            // checkBoxAutoClose
            // 
            this.checkBoxAutoClose.AutoSize = true;
            this.checkBoxAutoClose.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAutoClose.Checked = true;
            this.checkBoxAutoClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoClose.Location = new System.Drawing.Point(338, 495);
            this.checkBoxAutoClose.Name = "checkBoxAutoClose";
            this.checkBoxAutoClose.Size = new System.Drawing.Size(94, 21);
            this.checkBoxAutoClose.TabIndex = 11;
            this.checkBoxAutoClose.Text = "AutoClose";
            this.checkBoxAutoClose.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Location = new System.Drawing.Point(290, 209);
            this.pictureBoxPreview.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(143, 83);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 19;
            this.pictureBoxPreview.TabStop = false;
            // 
            // buttonLoadDirectory
            // 
            this.buttonLoadDirectory.Location = new System.Drawing.Point(14, 14);
            this.buttonLoadDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoadDirectory.Name = "buttonLoadDirectory";
            this.buttonLoadDirectory.Size = new System.Drawing.Size(131, 28);
            this.buttonLoadDirectory.TabIndex = 2;
            this.buttonLoadDirectory.Text = "Load Directory";
            this.buttonLoadDirectory.UseVisualStyleBackColor = true;
            this.buttonLoadDirectory.Click += new System.EventHandler(this.buttonLoadDirectory_Click);
            // 
            // labelFolder
            // 
            this.labelFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFolder.Location = new System.Drawing.Point(140, 299);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(298, 46);
            this.labelFolder.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Base Folder";
            // 
            // textBoxResX
            // 
            this.textBoxResX.Enabled = false;
            this.textBoxResX.Location = new System.Drawing.Point(255, 57);
            this.textBoxResX.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxResX.Name = "textBoxResX";
            this.textBoxResX.Size = new System.Drawing.Size(71, 22);
            this.textBoxResX.TabIndex = 4;
            this.textBoxResX.Text = "1280";
            this.textBoxResX.TextChanged += new System.EventHandler(this.textBoxResX_TextChanged);
            // 
            // textBoxResY
            // 
            this.textBoxResY.Enabled = false;
            this.textBoxResY.Location = new System.Drawing.Point(330, 58);
            this.textBoxResY.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxResY.Name = "textBoxResY";
            this.textBoxResY.Size = new System.Drawing.Size(70, 22);
            this.textBoxResY.TabIndex = 5;
            this.textBoxResY.Text = "720";
            this.textBoxResY.TextChanged += new System.EventHandler(this.textBoxResY_TextChanged);
            // 
            // buttonGenerateFilm
            // 
            this.buttonGenerateFilm.Location = new System.Drawing.Point(19, 395);
            this.buttonGenerateFilm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateFilm.Name = "buttonGenerateFilm";
            this.buttonGenerateFilm.Size = new System.Drawing.Size(298, 28);
            this.buttonGenerateFilm.TabIndex = 19;
            this.buttonGenerateFilm.Text = "Generate Zoom Effect";
            this.buttonGenerateFilm.UseVisualStyleBackColor = true;
            this.buttonGenerateFilm.Click += new System.EventHandler(this.buttonGenerateFilm_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonLoadFilm
            // 
            this.buttonLoadFilm.Location = new System.Drawing.Point(19, 14);
            this.buttonLoadFilm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoadFilm.Name = "buttonLoadFilm";
            this.buttonLoadFilm.Size = new System.Drawing.Size(142, 28);
            this.buttonLoadFilm.TabIndex = 12;
            this.buttonLoadFilm.Text = "Load Film";
            this.buttonLoadFilm.UseVisualStyleBackColor = true;
            this.buttonLoadFilm.Click += new System.EventHandler(this.buttonLoadFilm_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "x";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(151, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "y";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(285, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 17);
            this.label13.TabIndex = 32;
            this.label13.Text = "z";
            // 
            // zoomX
            // 
            this.zoomX.Location = new System.Drawing.Point(36, 147);
            this.zoomX.Margin = new System.Windows.Forms.Padding(2);
            this.zoomX.Name = "zoomX";
            this.zoomX.Size = new System.Drawing.Size(110, 22);
            this.zoomX.TabIndex = 14;
            this.zoomX.Text = "70";
            // 
            // zoomY
            // 
            this.zoomY.Location = new System.Drawing.Point(170, 147);
            this.zoomY.Margin = new System.Windows.Forms.Padding(2);
            this.zoomY.Name = "zoomY";
            this.zoomY.Size = new System.Drawing.Size(110, 22);
            this.zoomY.TabIndex = 15;
            this.zoomY.Text = "190";
            // 
            // zoomZ
            // 
            this.zoomZ.Location = new System.Drawing.Point(306, 147);
            this.zoomZ.Margin = new System.Windows.Forms.Padding(2);
            this.zoomZ.Name = "zoomZ";
            this.zoomZ.Size = new System.Drawing.Size(110, 22);
            this.zoomZ.TabIndex = 16;
            this.zoomZ.Text = "1.4";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 17);
            this.label14.TabIndex = 36;
            this.label14.Text = "Number of frames";
            // 
            // framesZoom
            // 
            this.framesZoom.Location = new System.Drawing.Point(164, 112);
            this.framesZoom.Margin = new System.Windows.Forms.Padding(2);
            this.framesZoom.Name = "framesZoom";
            this.framesZoom.Size = new System.Drawing.Size(110, 22);
            this.framesZoom.TabIndex = 13;
            this.framesZoom.TextChanged += new System.EventHandler(this.framesZoom_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTimelapse);
            this.tabControl1.Controls.Add(this.tabZoom);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(532, 589);
            this.tabControl1.TabIndex = 1;
            // 
            // tabTimelapse
            // 
            this.tabTimelapse.Controls.Add(this.buttonLoadDirectory);
            this.tabTimelapse.Controls.Add(this.label1);
            this.tabTimelapse.Controls.Add(this.label4);
            this.tabTimelapse.Controls.Add(this.labelStartNum);
            this.tabTimelapse.Controls.Add(this.comboBoxResolution);
            this.tabTimelapse.Controls.Add(this.label6);
            this.tabTimelapse.Controls.Add(this.labelNumFiles);
            this.tabTimelapse.Controls.Add(this.textBoxResX);
            this.tabTimelapse.Controls.Add(this.label8);
            this.tabTimelapse.Controls.Add(this.labelResolution);
            this.tabTimelapse.Controls.Add(this.textBoxResY);
            this.tabTimelapse.Controls.Add(this.label10);
            this.tabTimelapse.Controls.Add(this.labelAspectRatio);
            this.tabTimelapse.Controls.Add(this.label2);
            this.tabTimelapse.Controls.Add(this.pictureBoxPreview);
            this.tabTimelapse.Controls.Add(this.checkBoxAutoClose);
            this.tabTimelapse.Controls.Add(this.label9);
            this.tabTimelapse.Controls.Add(this.textBoxLog);
            this.tabTimelapse.Controls.Add(this.buttonGenerateVideo);
            this.tabTimelapse.Controls.Add(this.checkBoxSharpen);
            this.tabTimelapse.Controls.Add(this.labelFolder);
            this.tabTimelapse.Controls.Add(this.comboBoxScaleCrop);
            this.tabTimelapse.Controls.Add(this.label3);
            this.tabTimelapse.Controls.Add(this.label5);
            this.tabTimelapse.Controls.Add(this.numericUpDown1);
            this.tabTimelapse.Location = new System.Drawing.Point(4, 25);
            this.tabTimelapse.Name = "tabTimelapse";
            this.tabTimelapse.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimelapse.Size = new System.Drawing.Size(524, 560);
            this.tabTimelapse.TabIndex = 0;
            this.tabTimelapse.Text = "Timelapse";
            this.tabTimelapse.UseVisualStyleBackColor = true;
            // 
            // tabZoom
            // 
            this.tabZoom.Controls.Add(this.labelFilmLoaded);
            this.tabZoom.Controls.Add(this.label7);
            this.tabZoom.Controls.Add(this.checkBoxAutoCloseZoom);
            this.tabZoom.Controls.Add(this.label19);
            this.tabZoom.Controls.Add(this.textBoxOutputFileName);
            this.tabZoom.Controls.Add(this.label18);
            this.tabZoom.Controls.Add(this.label17);
            this.tabZoom.Controls.Add(this.textBoxOutputZoom);
            this.tabZoom.Controls.Add(this.buttonLoadFilm);
            this.tabZoom.Controls.Add(this.label14);
            this.tabZoom.Controls.Add(this.label11);
            this.tabZoom.Controls.Add(this.buttonGenerateFilm);
            this.tabZoom.Controls.Add(this.framesZoom);
            this.tabZoom.Controls.Add(this.label12);
            this.tabZoom.Controls.Add(this.label13);
            this.tabZoom.Controls.Add(this.zoomZ);
            this.tabZoom.Controls.Add(this.zoomX);
            this.tabZoom.Controls.Add(this.zoomY);
            this.tabZoom.Location = new System.Drawing.Point(4, 25);
            this.tabZoom.Name = "tabZoom";
            this.tabZoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabZoom.Size = new System.Drawing.Size(524, 560);
            this.tabZoom.TabIndex = 1;
            this.tabZoom.Text = "Zoom effect";
            this.tabZoom.UseVisualStyleBackColor = true;
            // 
            // labelFilmLoaded
            // 
            this.labelFilmLoaded.AutoSize = true;
            this.labelFilmLoaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilmLoaded.Location = new System.Drawing.Point(115, 56);
            this.labelFilmLoaded.Name = "labelFilmLoaded";
            this.labelFilmLoaded.Size = new System.Drawing.Size(0, 17);
            this.labelFilmLoaded.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Film loaded:";
            // 
            // checkBoxAutoCloseZoom
            // 
            this.checkBoxAutoCloseZoom.AutoSize = true;
            this.checkBoxAutoCloseZoom.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAutoCloseZoom.Checked = true;
            this.checkBoxAutoCloseZoom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoCloseZoom.Location = new System.Drawing.Point(322, 402);
            this.checkBoxAutoCloseZoom.Name = "checkBoxAutoCloseZoom";
            this.checkBoxAutoCloseZoom.Size = new System.Drawing.Size(94, 21);
            this.checkBoxAutoCloseZoom.TabIndex = 20;
            this.checkBoxAutoCloseZoom.Text = "AutoClose";
            this.checkBoxAutoCloseZoom.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(432, 188);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 17);
            this.label19.TabIndex = 44;
            this.label19.Text = ".mp4";
            // 
            // textBoxOutputFileName
            // 
            this.textBoxOutputFileName.Location = new System.Drawing.Point(164, 183);
            this.textBoxOutputFileName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOutputFileName.Name = "textBoxOutputFileName";
            this.textBoxOutputFileName.Size = new System.Drawing.Size(252, 22);
            this.textBoxOutputFileName.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(16, 186);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(133, 17);
            this.label18.TabIndex = 42;
            this.label18.Text = "Output file name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(16, 222);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 17);
            this.label17.TabIndex = 41;
            this.label17.Text = "Output command";
            // 
            // textBoxOutputZoom
            // 
            this.textBoxOutputZoom.Location = new System.Drawing.Point(19, 253);
            this.textBoxOutputZoom.Multiline = true;
            this.textBoxOutputZoom.Name = "textBoxOutputZoom";
            this.textBoxOutputZoom.Size = new System.Drawing.Size(397, 110);
            this.textBoxOutputZoom.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 618);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "FFMPEGUtil - September 27th 2019";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabTimelapse.ResumeLayout(false);
            this.tabTimelapse.PerformLayout();
            this.tabZoom.ResumeLayout(false);
            this.tabZoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxResolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxSharpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGenerateVideo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RichTextBox textBoxLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelStartNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNumFiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxScaleCrop;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelAspectRatio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxAutoClose;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Button buttonLoadDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxResX;
        private System.Windows.Forms.TextBox textBoxResY;
        private System.Windows.Forms.Button buttonGenerateFilm;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonLoadFilm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox zoomX;
        private System.Windows.Forms.TextBox zoomY;
        private System.Windows.Forms.TextBox zoomZ;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox framesZoom;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTimelapse;
        private System.Windows.Forms.TabPage tabZoom;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxOutputZoom;
        private System.Windows.Forms.TextBox textBoxOutputFileName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox checkBoxAutoCloseZoom;
        private System.Windows.Forms.Label labelFilmLoaded;
        private System.Windows.Forms.Label label7;
    }
}

