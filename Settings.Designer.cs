﻿namespace GHelper
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            checkStartup = new CheckBox();
            trackBattery = new TrackBar();
            labelBatteryTitle = new Label();
            pictureBattery = new PictureBox();
            labelGPUFan = new Label();
            tableGPU = new TableLayoutPanel();
            buttonUltimate = new Button();
            buttonStandard = new Button();
            buttonEco = new Button();
            labelGPU = new Label();
            pictureGPU = new PictureBox();
            labelCPUFan = new Label();
            tablePerf = new TableLayoutPanel();
            buttonTurbo = new Button();
            buttonBalanced = new Button();
            buttonSilent = new Button();
            picturePerf = new PictureBox();
            labelPerf = new Label();
            checkGPU = new CheckBox();
            buttonQuit = new Button();
            pictureScreen = new PictureBox();
            labelSreen = new Label();
            tableScreen = new TableLayoutPanel();
            button120Hz = new Button();
            button60Hz = new Button();
            checkScreen = new CheckBox();
            checkBoost = new CheckBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            comboKeyboard = new ComboBox();
            buttonKeyboardColor = new Button();
            labelBattery = new Label();
            buttonFans = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBattery).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBattery).BeginInit();
            tableGPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureGPU).BeginInit();
            tablePerf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturePerf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureScreen).BeginInit();
            tableScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // checkStartup
            // 
            checkStartup.AutoSize = true;
            checkStartup.Location = new Point(41, 1007);
            checkStartup.Margin = new Padding(4, 2, 4, 2);
            checkStartup.Name = "checkStartup";
            checkStartup.Size = new Size(206, 36);
            checkStartup.TabIndex = 2;
            checkStartup.Text = "Run on Startup";
            checkStartup.UseVisualStyleBackColor = true;
            checkStartup.CheckedChanged += checkStartup_CheckedChanged;
            // 
            // trackBattery
            // 
            trackBattery.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trackBattery.LargeChange = 20;
            trackBattery.Location = new Point(20, 909);
            trackBattery.Margin = new Padding(4, 2, 4, 2);
            trackBattery.Maximum = 100;
            trackBattery.Minimum = 50;
            trackBattery.Name = "trackBattery";
            trackBattery.Size = new Size(674, 90);
            trackBattery.SmallChange = 10;
            trackBattery.TabIndex = 3;
            trackBattery.TickFrequency = 10;
            trackBattery.TickStyle = TickStyle.TopLeft;
            trackBattery.Value = 100;
            // 
            // labelBatteryTitle
            // 
            labelBatteryTitle.AutoSize = true;
            labelBatteryTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBatteryTitle.Location = new Point(76, 870);
            labelBatteryTitle.Margin = new Padding(4, 0, 4, 0);
            labelBatteryTitle.Name = "labelBatteryTitle";
            labelBatteryTitle.Size = new Size(248, 32);
            labelBatteryTitle.TabIndex = 4;
            labelBatteryTitle.Text = "Battery Charge Limit";
            // 
            // pictureBattery
            // 
            pictureBattery.BackgroundImage = (Image)resources.GetObject("pictureBattery.BackgroundImage");
            pictureBattery.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBattery.Location = new Point(33, 868);
            pictureBattery.Margin = new Padding(4, 2, 4, 2);
            pictureBattery.Name = "pictureBattery";
            pictureBattery.Size = new Size(37, 38);
            pictureBattery.TabIndex = 6;
            pictureBattery.TabStop = false;
            // 
            // labelGPUFan
            // 
            labelGPUFan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelGPUFan.Location = new Point(409, 262);
            labelGPUFan.Margin = new Padding(4, 0, 4, 0);
            labelGPUFan.Name = "labelGPUFan";
            labelGPUFan.Size = new Size(277, 32);
            labelGPUFan.TabIndex = 8;
            labelGPUFan.Text = "GPU Fan : 0%";
            labelGPUFan.TextAlign = ContentAlignment.TopRight;
            // 
            // tableGPU
            // 
            tableGPU.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableGPU.ColumnCount = 3;
            tableGPU.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableGPU.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableGPU.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableGPU.Controls.Add(buttonUltimate, 2, 0);
            tableGPU.Controls.Add(buttonStandard, 1, 0);
            tableGPU.Controls.Add(buttonEco, 0, 0);
            tableGPU.Location = new Point(22, 303);
            tableGPU.Margin = new Padding(4, 2, 4, 2);
            tableGPU.Name = "tableGPU";
            tableGPU.RowCount = 1;
            tableGPU.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            tableGPU.Size = new Size(674, 107);
            tableGPU.TabIndex = 7;
            // 
            // buttonUltimate
            // 
            buttonUltimate.BackColor = SystemColors.ControlLightLight;
            buttonUltimate.Dock = DockStyle.Fill;
            buttonUltimate.FlatAppearance.BorderSize = 0;
            buttonUltimate.FlatStyle = FlatStyle.Flat;
            buttonUltimate.Location = new Point(457, 11);
            buttonUltimate.Margin = new Padding(9, 11, 9, 11);
            buttonUltimate.Name = "buttonUltimate";
            buttonUltimate.Size = new Size(208, 85);
            buttonUltimate.TabIndex = 2;
            buttonUltimate.Text = "Ultimate";
            buttonUltimate.UseVisualStyleBackColor = false;
            // 
            // buttonStandard
            // 
            buttonStandard.BackColor = SystemColors.ControlLightLight;
            buttonStandard.Dock = DockStyle.Fill;
            buttonStandard.FlatAppearance.BorderSize = 0;
            buttonStandard.FlatStyle = FlatStyle.Flat;
            buttonStandard.Location = new Point(233, 11);
            buttonStandard.Margin = new Padding(9, 11, 9, 11);
            buttonStandard.Name = "buttonStandard";
            buttonStandard.Size = new Size(206, 85);
            buttonStandard.TabIndex = 1;
            buttonStandard.Text = "Standard";
            buttonStandard.UseVisualStyleBackColor = false;
            // 
            // buttonEco
            // 
            buttonEco.BackColor = SystemColors.ControlLightLight;
            buttonEco.CausesValidation = false;
            buttonEco.Dock = DockStyle.Fill;
            buttonEco.FlatAppearance.BorderSize = 0;
            buttonEco.FlatStyle = FlatStyle.Flat;
            buttonEco.Location = new Point(9, 11);
            buttonEco.Margin = new Padding(9, 11, 9, 11);
            buttonEco.Name = "buttonEco";
            buttonEco.Size = new Size(206, 85);
            buttonEco.TabIndex = 0;
            buttonEco.Text = "Eco";
            buttonEco.UseVisualStyleBackColor = false;
            // 
            // labelGPU
            // 
            labelGPU.AutoSize = true;
            labelGPU.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGPU.Location = new Point(76, 265);
            labelGPU.Margin = new Padding(4, 0, 4, 0);
            labelGPU.Name = "labelGPU";
            labelGPU.Size = new Size(136, 32);
            labelGPU.TabIndex = 9;
            labelGPU.Text = "GPU Mode";
            // 
            // pictureGPU
            // 
            pictureGPU.BackgroundImage = (Image)resources.GetObject("pictureGPU.BackgroundImage");
            pictureGPU.BackgroundImageLayout = ImageLayout.Zoom;
            pictureGPU.Location = new Point(33, 262);
            pictureGPU.Margin = new Padding(4, 2, 4, 2);
            pictureGPU.Name = "pictureGPU";
            pictureGPU.Size = new Size(37, 38);
            pictureGPU.TabIndex = 10;
            pictureGPU.TabStop = false;
            // 
            // labelCPUFan
            // 
            labelCPUFan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCPUFan.Location = new Point(409, 38);
            labelCPUFan.Margin = new Padding(4, 0, 4, 0);
            labelCPUFan.Name = "labelCPUFan";
            labelCPUFan.Size = new Size(277, 32);
            labelCPUFan.TabIndex = 12;
            labelCPUFan.Text = "CPU Fan : 0%";
            labelCPUFan.TextAlign = ContentAlignment.TopRight;
            // 
            // tablePerf
            // 
            tablePerf.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tablePerf.ColumnCount = 3;
            tablePerf.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tablePerf.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tablePerf.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tablePerf.Controls.Add(buttonTurbo, 2, 0);
            tablePerf.Controls.Add(buttonBalanced, 1, 0);
            tablePerf.Controls.Add(buttonSilent, 0, 0);
            tablePerf.Location = new Point(22, 77);
            tablePerf.Margin = new Padding(4, 2, 4, 2);
            tablePerf.Name = "tablePerf";
            tablePerf.RowCount = 1;
            tablePerf.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            tablePerf.Size = new Size(674, 107);
            tablePerf.TabIndex = 11;
            // 
            // buttonTurbo
            // 
            buttonTurbo.BackColor = SystemColors.ControlLightLight;
            buttonTurbo.Dock = DockStyle.Fill;
            buttonTurbo.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            buttonTurbo.FlatAppearance.BorderSize = 0;
            buttonTurbo.FlatStyle = FlatStyle.Flat;
            buttonTurbo.Location = new Point(457, 11);
            buttonTurbo.Margin = new Padding(9, 11, 9, 11);
            buttonTurbo.Name = "buttonTurbo";
            buttonTurbo.Size = new Size(208, 85);
            buttonTurbo.TabIndex = 2;
            buttonTurbo.Text = "Turbo";
            buttonTurbo.UseVisualStyleBackColor = false;
            // 
            // buttonBalanced
            // 
            buttonBalanced.BackColor = SystemColors.ControlLightLight;
            buttonBalanced.Dock = DockStyle.Fill;
            buttonBalanced.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            buttonBalanced.FlatAppearance.BorderSize = 0;
            buttonBalanced.FlatStyle = FlatStyle.Flat;
            buttonBalanced.Location = new Point(233, 11);
            buttonBalanced.Margin = new Padding(9, 11, 9, 11);
            buttonBalanced.Name = "buttonBalanced";
            buttonBalanced.Size = new Size(206, 85);
            buttonBalanced.TabIndex = 1;
            buttonBalanced.Text = "Balanced";
            buttonBalanced.UseVisualStyleBackColor = false;
            // 
            // buttonSilent
            // 
            buttonSilent.BackColor = SystemColors.ControlLightLight;
            buttonSilent.CausesValidation = false;
            buttonSilent.Dock = DockStyle.Fill;
            buttonSilent.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            buttonSilent.FlatAppearance.BorderSize = 0;
            buttonSilent.FlatStyle = FlatStyle.Flat;
            buttonSilent.Location = new Point(9, 11);
            buttonSilent.Margin = new Padding(9, 11, 9, 11);
            buttonSilent.Name = "buttonSilent";
            buttonSilent.Size = new Size(206, 85);
            buttonSilent.TabIndex = 0;
            buttonSilent.Text = "Silent";
            buttonSilent.UseVisualStyleBackColor = false;
            // 
            // picturePerf
            // 
            picturePerf.BackgroundImage = (Image)resources.GetObject("picturePerf.BackgroundImage");
            picturePerf.BackgroundImageLayout = ImageLayout.Zoom;
            picturePerf.InitialImage = null;
            picturePerf.Location = new Point(33, 36);
            picturePerf.Margin = new Padding(4, 2, 4, 2);
            picturePerf.Name = "picturePerf";
            picturePerf.Size = new Size(37, 38);
            picturePerf.TabIndex = 14;
            picturePerf.TabStop = false;
            // 
            // labelPerf
            // 
            labelPerf.AutoSize = true;
            labelPerf.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPerf.Location = new Point(76, 38);
            labelPerf.Margin = new Padding(4, 0, 4, 0);
            labelPerf.Name = "labelPerf";
            labelPerf.Size = new Size(234, 32);
            labelPerf.TabIndex = 13;
            labelPerf.Text = "Performance Mode";
            // 
            // checkGPU
            // 
            checkGPU.AutoSize = true;
            checkGPU.ForeColor = SystemColors.GrayText;
            checkGPU.Location = new Point(33, 412);
            checkGPU.Margin = new Padding(4, 2, 4, 2);
            checkGPU.Name = "checkGPU";
            checkGPU.Size = new Size(550, 36);
            checkGPU.TabIndex = 15;
            checkGPU.Text = "Set Eco on battery and Standard when plugged";
            checkGPU.UseVisualStyleBackColor = true;
            checkGPU.CheckedChanged += checkGPU_CheckedChanged;
            // 
            // buttonQuit
            // 
            buttonQuit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonQuit.BackColor = SystemColors.ButtonFace;
            buttonQuit.Location = new Point(574, 1011);
            buttonQuit.Margin = new Padding(4, 2, 4, 2);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Size = new Size(121, 47);
            buttonQuit.TabIndex = 16;
            buttonQuit.Text = "Quit";
            buttonQuit.UseVisualStyleBackColor = false;
            // 
            // pictureScreen
            // 
            pictureScreen.BackgroundImage = (Image)resources.GetObject("pictureScreen.BackgroundImage");
            pictureScreen.BackgroundImageLayout = ImageLayout.Zoom;
            pictureScreen.Location = new Point(33, 495);
            pictureScreen.Margin = new Padding(4, 2, 4, 2);
            pictureScreen.Name = "pictureScreen";
            pictureScreen.Size = new Size(37, 38);
            pictureScreen.TabIndex = 18;
            pictureScreen.TabStop = false;
            // 
            // labelSreen
            // 
            labelSreen.AutoSize = true;
            labelSreen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSreen.Location = new Point(76, 495);
            labelSreen.Margin = new Padding(4, 0, 4, 0);
            labelSreen.Name = "labelSreen";
            labelSreen.Size = new Size(176, 32);
            labelSreen.TabIndex = 17;
            labelSreen.Text = "Laptop Screen";
            // 
            // tableScreen
            // 
            tableScreen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableScreen.ColumnCount = 3;
            tableScreen.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableScreen.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableScreen.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableScreen.Controls.Add(button120Hz, 1, 0);
            tableScreen.Controls.Add(button60Hz, 0, 0);
            tableScreen.Location = new Point(22, 535);
            tableScreen.Margin = new Padding(4, 2, 4, 2);
            tableScreen.Name = "tableScreen";
            tableScreen.RowCount = 1;
            tableScreen.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            tableScreen.Size = new Size(674, 107);
            tableScreen.TabIndex = 19;
            // 
            // button120Hz
            // 
            button120Hz.BackColor = SystemColors.ControlLightLight;
            button120Hz.Dock = DockStyle.Fill;
            button120Hz.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            button120Hz.FlatAppearance.BorderSize = 0;
            button120Hz.FlatStyle = FlatStyle.Flat;
            button120Hz.Location = new Point(233, 11);
            button120Hz.Margin = new Padding(9, 11, 9, 11);
            button120Hz.Name = "button120Hz";
            button120Hz.Size = new Size(206, 85);
            button120Hz.TabIndex = 1;
            button120Hz.Text = "120Hz + OD";
            button120Hz.UseVisualStyleBackColor = false;
            // 
            // button60Hz
            // 
            button60Hz.BackColor = SystemColors.ControlLightLight;
            button60Hz.CausesValidation = false;
            button60Hz.Dock = DockStyle.Fill;
            button60Hz.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            button60Hz.FlatAppearance.BorderSize = 0;
            button60Hz.FlatStyle = FlatStyle.Flat;
            button60Hz.ForeColor = SystemColors.ControlText;
            button60Hz.Location = new Point(9, 11);
            button60Hz.Margin = new Padding(9, 11, 9, 11);
            button60Hz.Name = "button60Hz";
            button60Hz.Size = new Size(206, 85);
            button60Hz.TabIndex = 0;
            button60Hz.Text = "60Hz";
            button60Hz.UseVisualStyleBackColor = false;
            // 
            // checkScreen
            // 
            checkScreen.AutoSize = true;
            checkScreen.ForeColor = SystemColors.GrayText;
            checkScreen.Location = new Point(33, 644);
            checkScreen.Margin = new Padding(4, 2, 4, 2);
            checkScreen.Name = "checkScreen";
            checkScreen.Size = new Size(527, 36);
            checkScreen.TabIndex = 20;
            checkScreen.Text = "Set 60Hz on battery, and back when plugged";
            checkScreen.UseVisualStyleBackColor = true;
            // 
            // checkBoost
            // 
            checkBoost.AutoSize = true;
            checkBoost.ForeColor = SystemColors.GrayText;
            checkBoost.Location = new Point(33, 184);
            checkBoost.Margin = new Padding(4, 2, 4, 2);
            checkBoost.Name = "checkBoost";
            checkBoost.Size = new Size(250, 36);
            checkBoost.TabIndex = 21;
            checkBoost.Text = "CPU Boost enabled";
            checkBoost.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.icons8_keyboard_48;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(33, 725);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 36);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(76, 725);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(210, 32);
            label1.TabIndex = 22;
            label1.Text = "Laptop Keyboard";
            // 
            // comboKeyboard
            // 
            comboKeyboard.FlatStyle = FlatStyle.Flat;
            comboKeyboard.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboKeyboard.FormattingEnabled = true;
            comboKeyboard.ItemHeight = 37;
            comboKeyboard.Items.AddRange(new object[] { "Static", "Breathe", "Strobe", "Rainbow" });
            comboKeyboard.Location = new Point(37, 777);
            comboKeyboard.Margin = new Padding(0);
            comboKeyboard.Name = "comboKeyboard";
            comboKeyboard.Size = new Size(201, 45);
            comboKeyboard.TabIndex = 24;
            comboKeyboard.TabStop = false;
            // 
            // buttonKeyboardColor
            // 
            buttonKeyboardColor.AutoSize = true;
            buttonKeyboardColor.BackColor = SystemColors.ButtonHighlight;
            buttonKeyboardColor.FlatAppearance.BorderColor = Color.Red;
            buttonKeyboardColor.FlatAppearance.BorderSize = 2;
            buttonKeyboardColor.FlatStyle = FlatStyle.Flat;
            buttonKeyboardColor.ForeColor = SystemColors.ControlText;
            buttonKeyboardColor.Location = new Point(256, 775);
            buttonKeyboardColor.Margin = new Padding(0);
            buttonKeyboardColor.Name = "buttonKeyboardColor";
            buttonKeyboardColor.Size = new Size(212, 50);
            buttonKeyboardColor.TabIndex = 25;
            buttonKeyboardColor.Text = "Color";
            buttonKeyboardColor.UseVisualStyleBackColor = false;
            // 
            // labelBattery
            // 
            labelBattery.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelBattery.Location = new Point(409, 868);
            labelBattery.Margin = new Padding(4, 0, 4, 0);
            labelBattery.Name = "labelBattery";
            labelBattery.Size = new Size(277, 32);
            labelBattery.TabIndex = 27;
            labelBattery.Text = "                ";
            labelBattery.TextAlign = ContentAlignment.TopRight;
            // 
            // buttonFans
            // 
            buttonFans.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFans.BackColor = SystemColors.ButtonFace;
            buttonFans.Location = new Point(525, 186);
            buttonFans.Margin = new Padding(4, 2, 4, 2);
            buttonFans.Name = "buttonFans";
            buttonFans.Size = new Size(165, 47);
            buttonFans.TabIndex = 28;
            buttonFans.Text = "Fan Profile";
            buttonFans.UseVisualStyleBackColor = false;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 1079);
            Controls.Add(buttonFans);
            Controls.Add(labelBattery);
            Controls.Add(buttonKeyboardColor);
            Controls.Add(comboKeyboard);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(checkBoost);
            Controls.Add(checkScreen);
            Controls.Add(tableScreen);
            Controls.Add(pictureScreen);
            Controls.Add(labelSreen);
            Controls.Add(buttonQuit);
            Controls.Add(checkGPU);
            Controls.Add(picturePerf);
            Controls.Add(labelPerf);
            Controls.Add(labelCPUFan);
            Controls.Add(tablePerf);
            Controls.Add(pictureGPU);
            Controls.Add(labelGPU);
            Controls.Add(labelGPUFan);
            Controls.Add(tableGPU);
            Controls.Add(pictureBattery);
            Controls.Add(labelBatteryTitle);
            Controls.Add(trackBattery);
            Controls.Add(checkStartup);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 2, 4, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            Padding = new Padding(9, 11, 9, 11);
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "G-Helper";
            Load += Settings_Load;
            ((System.ComponentModel.ISupportInitialize)trackBattery).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBattery).EndInit();
            tableGPU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureGPU).EndInit();
            tablePerf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picturePerf).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureScreen).EndInit();
            tableScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox checkStartup;
        private TrackBar trackBattery;
        private Label labelBatteryTitle;
        private PictureBox pictureBattery;
        private Label labelGPUFan;
        private TableLayoutPanel tableGPU;
        private Button buttonUltimate;
        private Button buttonStandard;
        private Button buttonEco;
        private Label labelGPU;
        private PictureBox pictureGPU;
        private Label labelCPUFan;
        private TableLayoutPanel tablePerf;
        private Button buttonTurbo;
        private Button buttonBalanced;
        private Button buttonSilent;
        private PictureBox picturePerf;
        private Label labelPerf;
        private CheckBox checkGPU;
        private Button buttonQuit;
        private PictureBox pictureScreen;
        private Label labelSreen;
        private TableLayoutPanel tableScreen;
        private Button button120Hz;
        private Button button60Hz;
        private CheckBox checkScreen;
        private CheckBox checkBoost;
        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox comboKeyboard;
        private Button buttonKeyboardColor;
        private Label labelBattery;
        private Button buttonFans;
    }
}