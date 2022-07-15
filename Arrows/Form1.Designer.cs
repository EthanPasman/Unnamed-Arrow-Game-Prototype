namespace Arrows
{
    partial class ArrowGameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArrowGameForm));
            this.DownArrowPB = new System.Windows.Forms.PictureBox();
            this.LeftArrowPB = new System.Windows.Forms.PictureBox();
            this.RightArrowPB = new System.Windows.Forms.PictureBox();
            this.UpArrowPB = new System.Windows.Forms.PictureBox();
            this.ScoreLbl = new System.Windows.Forms.Label();
            this.ComboLbl = new System.Windows.Forms.Label();
            this.ScoreTimer = new System.Windows.Forms.Timer(this.components);
            this.TimerLbl = new System.Windows.Forms.Label();
            this.GameLbl = new System.Windows.Forms.Label();
            this.PlayBtn60 = new System.Windows.Forms.Button();
            this.PlayBtn120 = new System.Windows.Forms.Button();
            this.PlayBtn300 = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.ResetTopBtn = new System.Windows.Forms.Button();
            this.SaveSettingsBtn = new System.Windows.Forms.Button();
            this.DiffSettingNUD = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.DiffRBOn = new System.Windows.Forms.RadioButton();
            this.DiffRBOff = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.ChangeCtrl4Btn = new System.Windows.Forms.Button();
            this.C4Lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ChangeCtrl3Btn = new System.Windows.Forms.Button();
            this.C3Lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ChangeCtrl2Btn = new System.Windows.Forms.Button();
            this.C2Lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ChangeCtrl1Btn = new System.Windows.Forms.Button();
            this.C1Lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GameOverPanel = new System.Windows.Forms.Panel();
            this.QuitEndBtn = new System.Windows.Forms.Button();
            this.MainMenuBtn = new System.Windows.Forms.Button();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.BestLbl = new System.Windows.Forms.Label();
            this.LComboLbl = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.LScoreLbl = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.FComboLbl = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.FScoreLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DownArrowPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrowPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightArrowPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpArrowPB)).BeginInit();
            this.MainMenuPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiffSettingNUD)).BeginInit();
            this.GameOverPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DownArrowPB
            // 
            this.DownArrowPB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DownArrowPB.BackColor = System.Drawing.Color.Transparent;
            this.DownArrowPB.Image = ((System.Drawing.Image)(resources.GetObject("DownArrowPB.Image")));
            this.DownArrowPB.Location = new System.Drawing.Point(335, 49);
            this.DownArrowPB.Name = "DownArrowPB";
            this.DownArrowPB.Size = new System.Drawing.Size(75, 75);
            this.DownArrowPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DownArrowPB.TabIndex = 0;
            this.DownArrowPB.TabStop = false;
            // 
            // LeftArrowPB
            // 
            this.LeftArrowPB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LeftArrowPB.BackColor = System.Drawing.Color.Transparent;
            this.LeftArrowPB.Image = ((System.Drawing.Image)(resources.GetObject("LeftArrowPB.Image")));
            this.LeftArrowPB.Location = new System.Drawing.Point(414, 49);
            this.LeftArrowPB.Name = "LeftArrowPB";
            this.LeftArrowPB.Size = new System.Drawing.Size(75, 75);
            this.LeftArrowPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftArrowPB.TabIndex = 1;
            this.LeftArrowPB.TabStop = false;
            // 
            // RightArrowPB
            // 
            this.RightArrowPB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RightArrowPB.BackColor = System.Drawing.Color.Transparent;
            this.RightArrowPB.Image = ((System.Drawing.Image)(resources.GetObject("RightArrowPB.Image")));
            this.RightArrowPB.Location = new System.Drawing.Point(493, 49);
            this.RightArrowPB.Name = "RightArrowPB";
            this.RightArrowPB.Size = new System.Drawing.Size(75, 75);
            this.RightArrowPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RightArrowPB.TabIndex = 2;
            this.RightArrowPB.TabStop = false;
            // 
            // UpArrowPB
            // 
            this.UpArrowPB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpArrowPB.BackColor = System.Drawing.Color.Transparent;
            this.UpArrowPB.Image = ((System.Drawing.Image)(resources.GetObject("UpArrowPB.Image")));
            this.UpArrowPB.Location = new System.Drawing.Point(572, 49);
            this.UpArrowPB.Name = "UpArrowPB";
            this.UpArrowPB.Size = new System.Drawing.Size(75, 75);
            this.UpArrowPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpArrowPB.TabIndex = 3;
            this.UpArrowPB.TabStop = false;
            // 
            // ScoreLbl
            // 
            this.ScoreLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScoreLbl.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLbl.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScoreLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ScoreLbl.Location = new System.Drawing.Point(450, -3);
            this.ScoreLbl.Name = "ScoreLbl";
            this.ScoreLbl.Size = new System.Drawing.Size(83, 26);
            this.ScoreLbl.TabIndex = 4;
            this.ScoreLbl.Text = "0";
            this.ScoreLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ComboLbl
            // 
            this.ComboLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboLbl.BackColor = System.Drawing.Color.Transparent;
            this.ComboLbl.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboLbl.Location = new System.Drawing.Point(450, 21);
            this.ComboLbl.Name = "ComboLbl";
            this.ComboLbl.Size = new System.Drawing.Size(83, 25);
            this.ComboLbl.TabIndex = 5;
            this.ComboLbl.Text = "0";
            this.ComboLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ScoreTimer
            // 
            this.ScoreTimer.Interval = 1000;
            // 
            // TimerLbl
            // 
            this.TimerLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimerLbl.BackColor = System.Drawing.Color.Transparent;
            this.TimerLbl.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimerLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TimerLbl.Location = new System.Drawing.Point(361, -3);
            this.TimerLbl.Name = "TimerLbl";
            this.TimerLbl.Size = new System.Drawing.Size(83, 26);
            this.TimerLbl.TabIndex = 6;
            this.TimerLbl.Text = "0";
            this.TimerLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GameLbl
            // 
            this.GameLbl.AutoSize = true;
            this.GameLbl.Font = new System.Drawing.Font("Helvetica", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameLbl.Location = new System.Drawing.Point(313, 127);
            this.GameLbl.Name = "GameLbl";
            this.GameLbl.Size = new System.Drawing.Size(366, 71);
            this.GameLbl.TabIndex = 7;
            this.GameLbl.Text = "Arrow Game";
            // 
            // PlayBtn60
            // 
            this.PlayBtn60.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn60.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayBtn60.Location = new System.Drawing.Point(3, 3);
            this.PlayBtn60.Name = "PlayBtn60";
            this.PlayBtn60.Size = new System.Drawing.Size(154, 31);
            this.PlayBtn60.TabIndex = 8;
            this.PlayBtn60.Text = "60 Seconds Challenge";
            this.PlayBtn60.UseVisualStyleBackColor = true;
            this.PlayBtn60.Click += new System.EventHandler(this.PlayBtn60_Click);
            // 
            // PlayBtn120
            // 
            this.PlayBtn120.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn120.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayBtn120.Location = new System.Drawing.Point(3, 40);
            this.PlayBtn120.Name = "PlayBtn120";
            this.PlayBtn120.Size = new System.Drawing.Size(154, 31);
            this.PlayBtn120.TabIndex = 9;
            this.PlayBtn120.Text = "120 Seconds Challenge";
            this.PlayBtn120.UseVisualStyleBackColor = true;
            this.PlayBtn120.Click += new System.EventHandler(this.PlayBtn120_Click);
            // 
            // PlayBtn300
            // 
            this.PlayBtn300.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn300.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayBtn300.Location = new System.Drawing.Point(3, 77);
            this.PlayBtn300.Name = "PlayBtn300";
            this.PlayBtn300.Size = new System.Drawing.Size(154, 31);
            this.PlayBtn300.TabIndex = 10;
            this.PlayBtn300.Text = "300 Seconds Challenge";
            this.PlayBtn300.UseVisualStyleBackColor = true;
            this.PlayBtn300.Click += new System.EventHandler(this.PlayBtn300_Click);
            // 
            // QuitBtn
            // 
            this.QuitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitBtn.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuitBtn.Location = new System.Drawing.Point(3, 151);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(154, 31);
            this.QuitBtn.TabIndex = 12;
            this.QuitBtn.Text = "Quit";
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingsBtn.Location = new System.Drawing.Point(3, 114);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(154, 31);
            this.SettingsBtn.TabIndex = 11;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.Controls.Add(this.PlayBtn60);
            this.MainMenuPanel.Controls.Add(this.QuitBtn);
            this.MainMenuPanel.Controls.Add(this.SettingsBtn);
            this.MainMenuPanel.Controls.Add(this.PlayBtn120);
            this.MainMenuPanel.Controls.Add(this.PlayBtn300);
            this.MainMenuPanel.Location = new System.Drawing.Point(414, 201);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(160, 186);
            this.MainMenuPanel.TabIndex = 13;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.DimGray;
            this.SettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SettingsPanel.Controls.Add(this.ResetTopBtn);
            this.SettingsPanel.Controls.Add(this.SaveSettingsBtn);
            this.SettingsPanel.Controls.Add(this.DiffSettingNUD);
            this.SettingsPanel.Controls.Add(this.label10);
            this.SettingsPanel.Controls.Add(this.DiffRBOn);
            this.SettingsPanel.Controls.Add(this.DiffRBOff);
            this.SettingsPanel.Controls.Add(this.label9);
            this.SettingsPanel.Controls.Add(this.ChangeCtrl4Btn);
            this.SettingsPanel.Controls.Add(this.C4Lbl);
            this.SettingsPanel.Controls.Add(this.label8);
            this.SettingsPanel.Controls.Add(this.ChangeCtrl3Btn);
            this.SettingsPanel.Controls.Add(this.C3Lbl);
            this.SettingsPanel.Controls.Add(this.label6);
            this.SettingsPanel.Controls.Add(this.ChangeCtrl2Btn);
            this.SettingsPanel.Controls.Add(this.C2Lbl);
            this.SettingsPanel.Controls.Add(this.label4);
            this.SettingsPanel.Controls.Add(this.ChangeCtrl1Btn);
            this.SettingsPanel.Controls.Add(this.C1Lbl);
            this.SettingsPanel.Controls.Add(this.label1);
            this.SettingsPanel.Location = new System.Drawing.Point(69, 49);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(186, 387);
            this.SettingsPanel.TabIndex = 14;
            // 
            // ResetTopBtn
            // 
            this.ResetTopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetTopBtn.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetTopBtn.Location = new System.Drawing.Point(3, 285);
            this.ResetTopBtn.Name = "ResetTopBtn";
            this.ResetTopBtn.Size = new System.Drawing.Size(178, 23);
            this.ResetTopBtn.TabIndex = 18;
            this.ResetTopBtn.TabStop = false;
            this.ResetTopBtn.Text = "Reset Local Top Score";
            this.ResetTopBtn.UseVisualStyleBackColor = true;
            this.ResetTopBtn.Click += new System.EventHandler(this.ResetTopBtn_Click);
            // 
            // SaveSettingsBtn
            // 
            this.SaveSettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSettingsBtn.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveSettingsBtn.Location = new System.Drawing.Point(3, 343);
            this.SaveSettingsBtn.Name = "SaveSettingsBtn";
            this.SaveSettingsBtn.Size = new System.Drawing.Size(180, 41);
            this.SaveSettingsBtn.TabIndex = 17;
            this.SaveSettingsBtn.TabStop = false;
            this.SaveSettingsBtn.Text = "Save Settings";
            this.SaveSettingsBtn.UseVisualStyleBackColor = true;
            this.SaveSettingsBtn.Click += new System.EventHandler(this.SaveSettingsBtn_Click);
            // 
            // DiffSettingNUD
            // 
            this.DiffSettingNUD.BackColor = System.Drawing.Color.Gray;
            this.DiffSettingNUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiffSettingNUD.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiffSettingNUD.ForeColor = System.Drawing.Color.Black;
            this.DiffSettingNUD.InterceptArrowKeys = false;
            this.DiffSettingNUD.Location = new System.Drawing.Point(5, 245);
            this.DiffSettingNUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DiffSettingNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DiffSettingNUD.Name = "DiffSettingNUD";
            this.DiffSettingNUD.ReadOnly = true;
            this.DiffSettingNUD.Size = new System.Drawing.Size(40, 22);
            this.DiffSettingNUD.TabIndex = 16;
            this.DiffSettingNUD.TabStop = false;
            this.DiffSettingNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DiffSettingNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(3, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 14);
            this.label10.TabIndex = 15;
            this.label10.Text = "Difficulty Level: (1-10)";
            // 
            // DiffRBOn
            // 
            this.DiffRBOn.AutoSize = true;
            this.DiffRBOn.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiffRBOn.Location = new System.Drawing.Point(51, 207);
            this.DiffRBOn.Name = "DiffRBOn";
            this.DiffRBOn.Size = new System.Drawing.Size(41, 18);
            this.DiffRBOn.TabIndex = 14;
            this.DiffRBOn.Text = "On";
            this.DiffRBOn.UseVisualStyleBackColor = true;
            this.DiffRBOn.CheckedChanged += new System.EventHandler(this.DiffRBOn_CheckedChanged);
            // 
            // DiffRBOff
            // 
            this.DiffRBOff.AutoSize = true;
            this.DiffRBOff.Checked = true;
            this.DiffRBOff.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiffRBOff.Location = new System.Drawing.Point(5, 207);
            this.DiffRBOff.Name = "DiffRBOff";
            this.DiffRBOff.Size = new System.Drawing.Size(40, 18);
            this.DiffRBOff.TabIndex = 13;
            this.DiffRBOff.TabStop = true;
            this.DiffRBOff.Text = "Off";
            this.DiffRBOff.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 14);
            this.label9.TabIndex = 12;
            this.label9.Text = "Constant Difficulty:";
            // 
            // ChangeCtrl4Btn
            // 
            this.ChangeCtrl4Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeCtrl4Btn.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeCtrl4Btn.Location = new System.Drawing.Point(3, 162);
            this.ChangeCtrl4Btn.Name = "ChangeCtrl4Btn";
            this.ChangeCtrl4Btn.Size = new System.Drawing.Size(75, 25);
            this.ChangeCtrl4Btn.TabIndex = 11;
            this.ChangeCtrl4Btn.TabStop = false;
            this.ChangeCtrl4Btn.Text = "Change";
            this.ChangeCtrl4Btn.UseVisualStyleBackColor = true;
            this.ChangeCtrl4Btn.Click += new System.EventHandler(this.ChangeCtrl4Btn_Click);
            // 
            // C4Lbl
            // 
            this.C4Lbl.AutoSize = true;
            this.C4Lbl.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C4Lbl.Location = new System.Drawing.Point(104, 145);
            this.C4Lbl.Name = "C4Lbl";
            this.C4Lbl.Size = new System.Drawing.Size(43, 14);
            this.C4Lbl.TabIndex = 10;
            this.C4Lbl.Text = "Up / W";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 14);
            this.label8.TabIndex = 9;
            this.label8.Text = "Control 4:";
            // 
            // ChangeCtrl3Btn
            // 
            this.ChangeCtrl3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeCtrl3Btn.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeCtrl3Btn.Location = new System.Drawing.Point(3, 117);
            this.ChangeCtrl3Btn.Name = "ChangeCtrl3Btn";
            this.ChangeCtrl3Btn.Size = new System.Drawing.Size(75, 25);
            this.ChangeCtrl3Btn.TabIndex = 8;
            this.ChangeCtrl3Btn.TabStop = false;
            this.ChangeCtrl3Btn.Text = "Change";
            this.ChangeCtrl3Btn.UseVisualStyleBackColor = true;
            this.ChangeCtrl3Btn.Click += new System.EventHandler(this.ChangeCtrl3Btn_Click);
            // 
            // C3Lbl
            // 
            this.C3Lbl.AutoSize = true;
            this.C3Lbl.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C3Lbl.Location = new System.Drawing.Point(104, 100);
            this.C3Lbl.Name = "C3Lbl";
            this.C3Lbl.Size = new System.Drawing.Size(54, 14);
            this.C3Lbl.TabIndex = 7;
            this.C3Lbl.Text = "Right / D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Control 3:";
            // 
            // ChangeCtrl2Btn
            // 
            this.ChangeCtrl2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeCtrl2Btn.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeCtrl2Btn.Location = new System.Drawing.Point(3, 72);
            this.ChangeCtrl2Btn.Name = "ChangeCtrl2Btn";
            this.ChangeCtrl2Btn.Size = new System.Drawing.Size(75, 25);
            this.ChangeCtrl2Btn.TabIndex = 5;
            this.ChangeCtrl2Btn.TabStop = false;
            this.ChangeCtrl2Btn.Text = "Change";
            this.ChangeCtrl2Btn.UseVisualStyleBackColor = true;
            this.ChangeCtrl2Btn.Click += new System.EventHandler(this.ChangeCtrl2Btn_Click);
            // 
            // C2Lbl
            // 
            this.C2Lbl.AutoSize = true;
            this.C2Lbl.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C2Lbl.Location = new System.Drawing.Point(104, 55);
            this.C2Lbl.Name = "C2Lbl";
            this.C2Lbl.Size = new System.Drawing.Size(43, 14);
            this.C2Lbl.TabIndex = 4;
            this.C2Lbl.Text = "Left / A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Control 2:";
            // 
            // ChangeCtrl1Btn
            // 
            this.ChangeCtrl1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeCtrl1Btn.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeCtrl1Btn.Location = new System.Drawing.Point(3, 27);
            this.ChangeCtrl1Btn.Name = "ChangeCtrl1Btn";
            this.ChangeCtrl1Btn.Size = new System.Drawing.Size(75, 25);
            this.ChangeCtrl1Btn.TabIndex = 2;
            this.ChangeCtrl1Btn.TabStop = false;
            this.ChangeCtrl1Btn.Text = "Change";
            this.ChangeCtrl1Btn.UseVisualStyleBackColor = true;
            this.ChangeCtrl1Btn.Click += new System.EventHandler(this.ChangeCtrl1Btn_Click);
            // 
            // C1Lbl
            // 
            this.C1Lbl.AutoSize = true;
            this.C1Lbl.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C1Lbl.Location = new System.Drawing.Point(104, 10);
            this.C1Lbl.Name = "C1Lbl";
            this.C1Lbl.Size = new System.Drawing.Size(56, 14);
            this.C1Lbl.TabIndex = 1;
            this.C1Lbl.Text = "Down / S";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control 1:";
            // 
            // GameOverPanel
            // 
            this.GameOverPanel.BackColor = System.Drawing.Color.DimGray;
            this.GameOverPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameOverPanel.Controls.Add(this.QuitEndBtn);
            this.GameOverPanel.Controls.Add(this.MainMenuBtn);
            this.GameOverPanel.Controls.Add(this.RestartBtn);
            this.GameOverPanel.Controls.Add(this.BestLbl);
            this.GameOverPanel.Controls.Add(this.LComboLbl);
            this.GameOverPanel.Controls.Add(this.label18);
            this.GameOverPanel.Controls.Add(this.LScoreLbl);
            this.GameOverPanel.Controls.Add(this.label16);
            this.GameOverPanel.Controls.Add(this.FComboLbl);
            this.GameOverPanel.Controls.Add(this.label14);
            this.GameOverPanel.Controls.Add(this.FScoreLbl);
            this.GameOverPanel.Controls.Add(this.label11);
            this.GameOverPanel.Location = new System.Drawing.Point(728, 49);
            this.GameOverPanel.Name = "GameOverPanel";
            this.GameOverPanel.Size = new System.Drawing.Size(200, 274);
            this.GameOverPanel.TabIndex = 15;
            this.GameOverPanel.EnabledChanged += new System.EventHandler(this.EndEnabledChanged);
            // 
            // QuitEndBtn
            // 
            this.QuitEndBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitEndBtn.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuitEndBtn.Location = new System.Drawing.Point(3, 244);
            this.QuitEndBtn.Name = "QuitEndBtn";
            this.QuitEndBtn.Size = new System.Drawing.Size(81, 23);
            this.QuitEndBtn.TabIndex = 11;
            this.QuitEndBtn.Text = "Quit";
            this.QuitEndBtn.UseVisualStyleBackColor = true;
            this.QuitEndBtn.Click += new System.EventHandler(this.QuitEndBtn_Click);
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuBtn.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuBtn.Location = new System.Drawing.Point(3, 216);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(81, 23);
            this.MainMenuBtn.TabIndex = 10;
            this.MainMenuBtn.Text = "Main Menu";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // RestartBtn
            // 
            this.RestartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartBtn.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RestartBtn.Location = new System.Drawing.Point(3, 187);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(81, 23);
            this.RestartBtn.TabIndex = 9;
            this.RestartBtn.Text = "Restart";
            this.RestartBtn.UseVisualStyleBackColor = true;
            this.RestartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // BestLbl
            // 
            this.BestLbl.AutoSize = true;
            this.BestLbl.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BestLbl.Location = new System.Drawing.Point(111, 11);
            this.BestLbl.Name = "BestLbl";
            this.BestLbl.Size = new System.Drawing.Size(86, 19);
            this.BestLbl.TabIndex = 8;
            this.BestLbl.Text = "New Best!!";
            // 
            // LComboLbl
            // 
            this.LComboLbl.AutoSize = true;
            this.LComboLbl.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LComboLbl.Location = new System.Drawing.Point(3, 160);
            this.LComboLbl.Name = "LComboLbl";
            this.LComboLbl.Size = new System.Drawing.Size(14, 14);
            this.LComboLbl.TabIndex = 7;
            this.LComboLbl.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(3, 146);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 14);
            this.label18.TabIndex = 6;
            this.label18.Text = "Local Top Combo:";
            // 
            // LScoreLbl
            // 
            this.LScoreLbl.AutoSize = true;
            this.LScoreLbl.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LScoreLbl.Location = new System.Drawing.Point(3, 115);
            this.LScoreLbl.Name = "LScoreLbl";
            this.LScoreLbl.Size = new System.Drawing.Size(14, 14);
            this.LScoreLbl.TabIndex = 5;
            this.LScoreLbl.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(3, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 14);
            this.label16.TabIndex = 4;
            this.label16.Text = "Local Top Score:";
            // 
            // FComboLbl
            // 
            this.FComboLbl.AutoSize = true;
            this.FComboLbl.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FComboLbl.Location = new System.Drawing.Point(3, 70);
            this.FComboLbl.Name = "FComboLbl";
            this.FComboLbl.Size = new System.Drawing.Size(14, 14);
            this.FComboLbl.TabIndex = 3;
            this.FComboLbl.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(3, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 14);
            this.label14.TabIndex = 2;
            this.label14.Text = "Best Combo:";
            // 
            // FScoreLbl
            // 
            this.FScoreLbl.AutoSize = true;
            this.FScoreLbl.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FScoreLbl.Location = new System.Drawing.Point(3, 25);
            this.FScoreLbl.Name = "FScoreLbl";
            this.FScoreLbl.Size = new System.Drawing.Size(14, 14);
            this.FScoreLbl.TabIndex = 1;
            this.FScoreLbl.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(3, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 14);
            this.label11.TabIndex = 0;
            this.label11.Text = "Final Score:";
            // 
            // ArrowGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.GameOverPanel);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.MainMenuPanel);
            this.Controls.Add(this.GameLbl);
            this.Controls.Add(this.TimerLbl);
            this.Controls.Add(this.ComboLbl);
            this.Controls.Add(this.ScoreLbl);
            this.Controls.Add(this.UpArrowPB);
            this.Controls.Add(this.RightArrowPB);
            this.Controls.Add(this.LeftArrowPB);
            this.Controls.Add(this.DownArrowPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "ArrowGameForm";
            this.Text = "Arrow Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClose);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.DownArrowPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrowPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightArrowPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpArrowPB)).EndInit();
            this.MainMenuPanel.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiffSettingNUD)).EndInit();
            this.GameOverPanel.ResumeLayout(false);
            this.GameOverPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox DownArrowPB;
        private PictureBox LeftArrowPB;
        private PictureBox RightArrowPB;
        private PictureBox UpArrowPB;
        private Label ScoreLbl;
        private Label ComboLbl;
        private System.Windows.Forms.Timer ScoreTimer;
        private Label TimerLbl;
        private Label GameLbl;
        private Button PlayBtn60;
        private Button PlayBtn120;
        private Button PlayBtn300;
        private Button QuitBtn;
        private Button SettingsBtn;
        private Panel MainMenuPanel;
        private Panel SettingsPanel;
        private Button ChangeCtrl4Btn;
        private Label C4Lbl;
        private Label label8;
        private Button ChangeCtrl3Btn;
        private Label C3Lbl;
        private Label label6;
        private Button ChangeCtrl2Btn;
        private Label C2Lbl;
        private Label label4;
        private Button ChangeCtrl1Btn;
        private Label C1Lbl;
        private Label label1;
        private RadioButton DiffRBOn;
        private RadioButton DiffRBOff;
        private Label label9;
        private Label label10;
        private NumericUpDown DiffSettingNUD;
        private Button ResetTopBtn;
        private Button SaveSettingsBtn;
        private Panel GameOverPanel;
        private Button QuitEndBtn;
        private Button MainMenuBtn;
        private Button RestartBtn;
        private Label BestLbl;
        private Label LComboLbl;
        private Label label18;
        private Label LScoreLbl;
        private Label label16;
        private Label FComboLbl;
        private Label label14;
        private Label FScoreLbl;
        private Label label11;
    }
}