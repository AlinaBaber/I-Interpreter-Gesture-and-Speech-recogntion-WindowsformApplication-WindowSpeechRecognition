namespace GestureRecognition
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cameraComboBox = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.capturedImage = new System.Windows.Forms.PictureBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.thresholdNumeric = new System.Windows.Forms.NumericUpDown();
            this.webcamImage = new System.Windows.Forms.PictureBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.recognizedGesture = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.result_text_box = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.resulrtxtbox = new System.Windows.Forms.RichTextBox();
            this.Text_Interpretation_btn = new System.Windows.Forms.Button();
            this.Speech_Interpretation_btn = new System.Windows.Forms.Button();
            this.Clear_Text_btn = new System.Windows.Forms.Button();
            this.windowsmediaplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.Stop_Text_btn = new System.Windows.Forms.Button();
            this.Play_Signlanguage_btn = new System.Windows.Forms.Button();
            this.Help_btn = new System.Windows.Forms.Button();
            this.Info_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Stop_play_btn = new System.Windows.Forms.Button();
            this.Replay_btn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pausebtn = new System.Windows.Forms.Button();
            this.previousbtn = new System.Windows.Forms.Button();
            this.Playlist = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.capturedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webcamImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsmediaplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraComboBox
            // 
            this.cameraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cameraComboBox.FormattingEnabled = true;
            this.cameraComboBox.Location = new System.Drawing.Point(438, 176);
            this.cameraComboBox.Name = "cameraComboBox";
            this.cameraComboBox.Size = new System.Drawing.Size(153, 21);
            this.cameraComboBox.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startButton.BackgroundImage")));
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Transparent;
            this.startButton.Location = new System.Drawing.Point(714, 162);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 100);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Hand Recogntion";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // capturedImage
            // 
            this.capturedImage.BackColor = System.Drawing.SystemColors.InfoText;
            this.capturedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.capturedImage.Location = new System.Drawing.Point(439, 483);
            this.capturedImage.Name = "capturedImage";
            this.capturedImage.Size = new System.Drawing.Size(305, 173);
            this.capturedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.capturedImage.TabIndex = 2;
            this.capturedImage.TabStop = false;
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Transparent;
            this.stopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopButton.BackgroundImage")));
            this.stopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.Transparent;
            this.stopButton.Location = new System.Drawing.Point(820, 162);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 100);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // thresholdNumeric
            // 
            this.thresholdNumeric.Location = new System.Drawing.Point(597, 177);
            this.thresholdNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.thresholdNumeric.Name = "thresholdNumeric";
            this.thresholdNumeric.ReadOnly = true;
            this.thresholdNumeric.Size = new System.Drawing.Size(94, 20);
            this.thresholdNumeric.TabIndex = 5;
            this.thresholdNumeric.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // webcamImage
            // 
            this.webcamImage.BackColor = System.Drawing.SystemColors.InfoText;
            this.webcamImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.webcamImage.Location = new System.Drawing.Point(439, 283);
            this.webcamImage.Name = "webcamImage";
            this.webcamImage.Size = new System.Drawing.Size(481, 372);
            this.webcamImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.webcamImage.TabIndex = 7;
            this.webcamImage.TabStop = false;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(750, 281);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(170, 374);
            this.textBox.TabIndex = 9;
            this.textBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(436, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Webcams list";
            // 
            // recognizedGesture
            // 
            this.recognizedGesture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.recognizedGesture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recognizedGesture.Location = new System.Drawing.Point(438, 232);
            this.recognizedGesture.Name = "recognizedGesture";
            this.recognizedGesture.ReadOnly = true;
            this.recognizedGesture.Size = new System.Drawing.Size(253, 26);
            this.recognizedGesture.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(594, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Threshold";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(440, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Webcam";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(440, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Captured and proccesed frame";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(436, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Recognized gesture";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::GestureRecognition.Properties.Resources._11;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(5, 662);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1360, 38);
            this.panel2.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1144, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Developed by Alina Baber";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(334, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "© Copyright 2015 - Iridium IT. All rights reserved";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::GestureRecognition.Properties.Resources._111;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(5, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 103);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::GestureRecognition.Properties.Resources.page2_img1;
            this.pictureBox1.Location = new System.Drawing.Point(1259, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(15, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(296, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Deaf and Dumb Communicator Interpreter.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(8, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(315, 42);
            this.label9.TabIndex = 0;
            this.label9.Text = "I-INTERPRETER";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(934, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(434, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Result Sign Language (Text to Sign Language/Speech To Sign Language):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(2, 432);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(239, 16);
            this.label13.TabIndex = 32;
            this.label13.Text = "Result Text ( For Speech to Text):";
            // 
            // result_text_box
            // 
            this.result_text_box.BackColor = System.Drawing.Color.White;
            this.result_text_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_text_box.ForeColor = System.Drawing.Color.Black;
            this.result_text_box.Location = new System.Drawing.Point(5, 453);
            this.result_text_box.Name = "result_text_box";
            this.result_text_box.Size = new System.Drawing.Size(310, 203);
            this.result_text_box.TabIndex = 31;
            this.result_text_box.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(5, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(320, 16);
            this.label15.TabIndex = 30;
            this.label15.Text = "Enter text ( For Text to Speech Interpretation):";
            // 
            // resulrtxtbox
            // 
            this.resulrtxtbox.BackColor = System.Drawing.Color.White;
            this.resulrtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resulrtxtbox.ForeColor = System.Drawing.Color.Black;
            this.resulrtxtbox.Location = new System.Drawing.Point(5, 175);
            this.resulrtxtbox.Name = "resulrtxtbox";
            this.resulrtxtbox.Size = new System.Drawing.Size(312, 205);
            this.resulrtxtbox.TabIndex = 26;
            this.resulrtxtbox.Text = "";
            // 
            // Text_Interpretation_btn
            // 
            this.Text_Interpretation_btn.BackColor = System.Drawing.Color.Transparent;
            this.Text_Interpretation_btn.BackgroundImage = global::GestureRecognition.Properties.Resources.button;
            this.Text_Interpretation_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Text_Interpretation_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Text_Interpretation_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Interpretation_btn.ForeColor = System.Drawing.Color.White;
            this.Text_Interpretation_btn.Location = new System.Drawing.Point(321, 175);
            this.Text_Interpretation_btn.Name = "Text_Interpretation_btn";
            this.Text_Interpretation_btn.Size = new System.Drawing.Size(100, 100);
            this.Text_Interpretation_btn.TabIndex = 37;
            this.Text_Interpretation_btn.Text = "Text to Speech";
            this.Text_Interpretation_btn.UseVisualStyleBackColor = false;
            this.Text_Interpretation_btn.Click += new System.EventHandler(this.Text_Interpretation_btn_Click);
            // 
            // Speech_Interpretation_btn
            // 
            this.Speech_Interpretation_btn.BackColor = System.Drawing.Color.Transparent;
            this.Speech_Interpretation_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Speech_Interpretation_btn.BackgroundImage")));
            this.Speech_Interpretation_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Speech_Interpretation_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Speech_Interpretation_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speech_Interpretation_btn.ForeColor = System.Drawing.Color.White;
            this.Speech_Interpretation_btn.Location = new System.Drawing.Point(321, 453);
            this.Speech_Interpretation_btn.Name = "Speech_Interpretation_btn";
            this.Speech_Interpretation_btn.Size = new System.Drawing.Size(100, 100);
            this.Speech_Interpretation_btn.TabIndex = 38;
            this.Speech_Interpretation_btn.Text = "Speech to Text";
            this.Speech_Interpretation_btn.UseVisualStyleBackColor = false;
            this.Speech_Interpretation_btn.Click += new System.EventHandler(this.Speech_Interpretation_btn_Click);
            // 
            // Clear_Text_btn
            // 
            this.Clear_Text_btn.BackColor = System.Drawing.Color.Transparent;
            this.Clear_Text_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Clear_Text_btn.BackgroundImage")));
            this.Clear_Text_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Clear_Text_btn.Enabled = false;
            this.Clear_Text_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear_Text_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Text_btn.ForeColor = System.Drawing.Color.White;
            this.Clear_Text_btn.Location = new System.Drawing.Point(321, 280);
            this.Clear_Text_btn.Name = "Clear_Text_btn";
            this.Clear_Text_btn.Size = new System.Drawing.Size(100, 100);
            this.Clear_Text_btn.TabIndex = 39;
            this.Clear_Text_btn.Text = "Clear";
            this.Clear_Text_btn.UseVisualStyleBackColor = false;
            this.Clear_Text_btn.Click += new System.EventHandler(this.Clear_Text_btn_Click);
            // 
            // windowsmediaplayer
            // 
            this.windowsmediaplayer.Enabled = true;
            this.windowsmediaplayer.Location = new System.Drawing.Point(934, 160);
            this.windowsmediaplayer.Name = "windowsmediaplayer";
            this.windowsmediaplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("windowsmediaplayer.OcxState")));
            this.windowsmediaplayer.Size = new System.Drawing.Size(323, 288);
            this.windowsmediaplayer.TabIndex = 40;
            this.windowsmediaplayer.TabStop = false;
            this.windowsmediaplayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.windowsmediaplayer_PlayStateChange);
            this.windowsmediaplayer.OpenPlaylistSwitch += new AxWMPLib._WMPOCXEvents_OpenPlaylistSwitchEventHandler(this.windowsmediaplayer_OpenPlaylistSwitch);
            // 
            // Stop_Text_btn
            // 
            this.Stop_Text_btn.BackColor = System.Drawing.Color.Transparent;
            this.Stop_Text_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Stop_Text_btn.BackgroundImage")));
            this.Stop_Text_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Stop_Text_btn.Enabled = false;
            this.Stop_Text_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stop_Text_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop_Text_btn.ForeColor = System.Drawing.Color.White;
            this.Stop_Text_btn.Location = new System.Drawing.Point(321, 557);
            this.Stop_Text_btn.Name = "Stop_Text_btn";
            this.Stop_Text_btn.Size = new System.Drawing.Size(100, 100);
            this.Stop_Text_btn.TabIndex = 41;
            this.Stop_Text_btn.Text = "Stop Text";
            this.Stop_Text_btn.UseVisualStyleBackColor = false;
            this.Stop_Text_btn.Click += new System.EventHandler(this.Stop_Text_btn_Click);
            // 
            // Play_Signlanguage_btn
            // 
            this.Play_Signlanguage_btn.BackColor = System.Drawing.Color.Transparent;
            this.Play_Signlanguage_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Play_Signlanguage_btn.BackgroundImage")));
            this.Play_Signlanguage_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Play_Signlanguage_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Play_Signlanguage_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play_Signlanguage_btn.ForeColor = System.Drawing.Color.White;
            this.Play_Signlanguage_btn.Location = new System.Drawing.Point(937, 456);
            this.Play_Signlanguage_btn.Name = "Play_Signlanguage_btn";
            this.Play_Signlanguage_btn.Size = new System.Drawing.Size(100, 100);
            this.Play_Signlanguage_btn.TabIndex = 42;
            this.Play_Signlanguage_btn.Text = "Play Sign Languge";
            this.Play_Signlanguage_btn.UseVisualStyleBackColor = false;
            this.Play_Signlanguage_btn.Click += new System.EventHandler(this.Play_Signlanguage_btn_Click);
            // 
            // Help_btn
            // 
            this.Help_btn.BackColor = System.Drawing.Color.Transparent;
            this.Help_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Help_btn.BackgroundImage")));
            this.Help_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Help_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help_btn.ForeColor = System.Drawing.Color.White;
            this.Help_btn.Location = new System.Drawing.Point(1048, 557);
            this.Help_btn.Name = "Help_btn";
            this.Help_btn.Size = new System.Drawing.Size(100, 100);
            this.Help_btn.TabIndex = 43;
            this.Help_btn.Text = "Help";
            this.Help_btn.UseVisualStyleBackColor = false;
            this.Help_btn.Click += new System.EventHandler(this.Help_btn_Click);
            // 
            // Info_btn
            // 
            this.Info_btn.BackColor = System.Drawing.Color.Transparent;
            this.Info_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Info_btn.BackgroundImage")));
            this.Info_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Info_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Info_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info_btn.ForeColor = System.Drawing.Color.White;
            this.Info_btn.Location = new System.Drawing.Point(1156, 557);
            this.Info_btn.Name = "Info_btn";
            this.Info_btn.Size = new System.Drawing.Size(100, 100);
            this.Info_btn.TabIndex = 44;
            this.Info_btn.Text = "About";
            this.Info_btn.UseVisualStyleBackColor = false;
            this.Info_btn.Click += new System.EventHandler(this.Info_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.Exit_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit_btn.BackgroundImage")));
            this.Exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.Location = new System.Drawing.Point(1263, 557);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(100, 100);
            this.Exit_btn.TabIndex = 45;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Stop_play_btn
            // 
            this.Stop_play_btn.BackColor = System.Drawing.Color.Transparent;
            this.Stop_play_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Stop_play_btn.BackgroundImage")));
            this.Stop_play_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Stop_play_btn.Enabled = false;
            this.Stop_play_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stop_play_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop_play_btn.ForeColor = System.Drawing.Color.White;
            this.Stop_play_btn.Location = new System.Drawing.Point(1154, 456);
            this.Stop_play_btn.Name = "Stop_play_btn";
            this.Stop_play_btn.Size = new System.Drawing.Size(100, 100);
            this.Stop_play_btn.TabIndex = 46;
            this.Stop_play_btn.Text = "Stop Playing";
            this.Stop_play_btn.UseVisualStyleBackColor = false;
            this.Stop_play_btn.Click += new System.EventHandler(this.Stop_play_btn_Click);
            // 
            // Replay_btn
            // 
            this.Replay_btn.BackColor = System.Drawing.Color.Transparent;
            this.Replay_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Replay_btn.BackgroundImage")));
            this.Replay_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Replay_btn.Enabled = false;
            this.Replay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Replay_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Replay_btn.ForeColor = System.Drawing.Color.White;
            this.Replay_btn.Location = new System.Drawing.Point(937, 557);
            this.Replay_btn.Name = "Replay_btn";
            this.Replay_btn.Size = new System.Drawing.Size(100, 100);
            this.Replay_btn.TabIndex = 47;
            this.Replay_btn.Text = "Replay";
            this.Replay_btn.UseVisualStyleBackColor = false;
            this.Replay_btn.Click += new System.EventHandler(this.Replay_btn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(93, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(232, 31);
            this.label16.TabIndex = 48;
            this.label16.Text = "TEXT TO SPEECH";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(93, 391);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(232, 31);
            this.label17.TabIndex = 49;
            this.label17.Text = "SPEECH TO TEXT";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(485, 110);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(347, 31);
            this.label18.TabIndex = 50;
            this.label18.Text = "PSL TO TEXT AND SPEECH";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(968, 107);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(355, 31);
            this.label19.TabIndex = 51;
            this.label19.Text = " TEXT AND SPEECH TO PSL";
            // 
            // pausebtn
            // 
            this.pausebtn.BackColor = System.Drawing.Color.Transparent;
            this.pausebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pausebtn.BackgroundImage")));
            this.pausebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pausebtn.Enabled = false;
            this.pausebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pausebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pausebtn.ForeColor = System.Drawing.Color.White;
            this.pausebtn.Location = new System.Drawing.Point(1048, 456);
            this.pausebtn.Name = "pausebtn";
            this.pausebtn.Size = new System.Drawing.Size(100, 100);
            this.pausebtn.TabIndex = 52;
            this.pausebtn.Text = "Pause ";
            this.pausebtn.UseVisualStyleBackColor = false;
            this.pausebtn.Click += new System.EventHandler(this.pausebtn_Click);
            // 
            // previousbtn
            // 
            this.previousbtn.BackColor = System.Drawing.Color.Transparent;
            this.previousbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previousbtn.BackgroundImage")));
            this.previousbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previousbtn.Enabled = false;
            this.previousbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.previousbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousbtn.ForeColor = System.Drawing.Color.White;
            this.previousbtn.Location = new System.Drawing.Point(1263, 456);
            this.previousbtn.Name = "previousbtn";
            this.previousbtn.Size = new System.Drawing.Size(100, 100);
            this.previousbtn.TabIndex = 53;
            this.previousbtn.Text = "Play Previous";
            this.previousbtn.UseVisualStyleBackColor = false;
            this.previousbtn.Click += new System.EventHandler(this.previousbtn_Click);
            // 
            // Playlist
            // 
            this.Playlist.FormattingEnabled = true;
            this.Playlist.Location = new System.Drawing.Point(1263, 161);
            this.Playlist.Name = "Playlist";
            this.Playlist.Size = new System.Drawing.Size(100, 290);
            this.Playlist.TabIndex = 54;
            this.Playlist.Click += new System.EventHandler(this.Playlist_Click);
            this.Playlist.SelectedIndexChanged += new System.EventHandler(this.Playlist_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GestureRecognition.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1372, 732);
            this.Controls.Add(this.Playlist);
            this.Controls.Add(this.previousbtn);
            this.Controls.Add(this.pausebtn);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Replay_btn);
            this.Controls.Add(this.Stop_play_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Info_btn);
            this.Controls.Add(this.Help_btn);
            this.Controls.Add(this.Play_Signlanguage_btn);
            this.Controls.Add(this.Stop_Text_btn);
            this.Controls.Add(this.windowsmediaplayer);
            this.Controls.Add(this.Clear_Text_btn);
            this.Controls.Add(this.Speech_Interpretation_btn);
            this.Controls.Add(this.Text_Interpretation_btn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.result_text_box);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.resulrtxtbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recognizedGesture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.webcamImage);
            this.Controls.Add(this.thresholdNumeric);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.capturedImage);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.cameraComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "I - Interpreter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capturedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webcamImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsmediaplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cameraComboBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox capturedImage;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.NumericUpDown thresholdNumeric;
        private System.Windows.Forms.PictureBox webcamImage;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox recognizedGesture;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox result_text_box;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox resulrtxtbox;
        private System.Windows.Forms.Button Text_Interpretation_btn;
        private System.Windows.Forms.Button Speech_Interpretation_btn;
        private System.Windows.Forms.Button Clear_Text_btn;
        private AxWMPLib.AxWindowsMediaPlayer windowsmediaplayer;
        private System.Windows.Forms.Button Stop_Text_btn;
        private System.Windows.Forms.Button Play_Signlanguage_btn;
        private System.Windows.Forms.Button Help_btn;
        private System.Windows.Forms.Button Info_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Stop_play_btn;
        private System.Windows.Forms.Button Replay_btn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button pausebtn;
        private System.Windows.Forms.Button previousbtn;
        private System.Windows.Forms.ListBox Playlist;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

