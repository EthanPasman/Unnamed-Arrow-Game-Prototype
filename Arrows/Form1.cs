namespace Arrows
{
    public partial class ArrowGameForm : Form
    {
        private int arrowEnabled;
        private int score;
        private int combo;
        private int maxCombo;
        private int rndX;
        private int rndY;
        private int level;
        private bool begin;
        private int startTime;
        private int seconds;
        private bool end;
        private bool inGame;
        private bool inSettings;
        private bool constDiff = false;
        private int cUpd;
        private char c1 = 'S';
        private char c2 = 'A';
        private char c3 = 'D';
        private char c4 = 'W';
        private string? line;
        private List<string> lines = new List<string>();
        private int localScore60;
        private int localCombo60;
        private int localScore120;
        private int localCombo120;
        private int localScore300;
        private int localCombo300;
        private int lscoreN;
        private int lcomboN;
        private int temp;
        private string localPath = "C:\\Users\\" + Environment.UserName + "\\Documents\\assets\\local.ini";
        System.Media.SoundPlayer GoodSound = new System.Media.SoundPlayer("C:\\Users\\" + Environment.UserName +
                "\\Documents\\assets\\good.wav");
        System.Media.SoundPlayer BadSound = new System.Media.SoundPlayer("C:\\Users\\" + Environment.UserName +
            "\\Documents\\assets\\bad.wav");

        public ArrowGameForm()
        {
            InitializeComponent();

            DownArrowPB.ImageLocation = "C:\\Users\\" + Environment.UserName + "\\Documents\\assets\\arrowDown.png";
            LeftArrowPB.ImageLocation = "C:\\Users\\" + Environment.UserName + "\\Documents\\assets\\arrowLeft.png";
            RightArrowPB.ImageLocation = "C:\\Users\\" + Environment.UserName + "\\Documents\\assets\\arrowRight.png";
            UpArrowPB.ImageLocation = "C:\\Users\\" + Environment.UserName + "\\Documents\\assets\\arrowUp.png";

            StreamReader loadSettings = new StreamReader(localPath);
            while ((line = loadSettings.ReadLine()) != null)
            {
                lines.Add(line.Split(':')[1]);
            }
            loadSettings.Close();

            localScore60 = Int32.Parse(lines[0]);
            localCombo60 = Int32.Parse(lines[1]);
            localScore120 = Int32.Parse(lines[2]);
            localCombo120 = Int32.Parse(lines[3]);
            localScore300 = Int32.Parse(lines[4]);
            localCombo300 = Int32.Parse(lines[5]);
            c1 = Char.Parse(lines[6]);
            c2 = Char.Parse(lines[7]);
            c3 = Char.Parse(lines[8]);
            c4 = Char.Parse(lines[9]);
            constDiff = bool.Parse(lines[10]);
            if (constDiff)
            {
                DiffRBOn.Checked = true;
                DiffRBOff.Checked = false;
                DiffSettingNUD.Enabled = true;
            } else
            {
                DiffRBOn.Checked = false;
                DiffRBOff.Checked = true;
                DiffSettingNUD.Enabled = false;
            }
            level = Int32.Parse(lines[11]);
            DiffSettingNUD.Value = level;
            lines.Clear();

            ScoreLbl.Left = (this.Width - ScoreLbl.Width) / 2;
            ComboLbl.Left = (this.Width - ComboLbl.Width) / 2;
            ScoreTimer.Tick += new EventHandler(TimerEventProcessed);

            C1Lbl.Text = "Down / " + c1;
            C2Lbl.Text = "Down / " + c2;
            C3Lbl.Text = "Down / " + c3;
            C4Lbl.Text = "Down / " + c4;

            rndX = 0;
            rndY = 0;
            seconds = 60;
            startTime = seconds;
            cUpd = 0;
            ScoreTimer.Interval = 1000;

            ShowMenu();
        }

        private void ShowMenu()
        {
            inGame = false;
            inSettings = false;

            GameLbl.Visible = true;
            MainMenuPanel.Visible = true;
            MainMenuPanel.Enabled = true;
            SettingsPanel.Visible = false;
            SettingsPanel.Enabled = false;
            GameOverPanel.Visible = false;
            GameOverPanel.Enabled = false;

            this.BackColor = Color.Gray;
            ScoreLbl.Visible = false;
            ComboLbl.Visible = false;
            TimerLbl.Visible = false;
        }
        
        private void GameStart(int s)
        {
            inGame = true;
            seconds = s;
            startTime = s;
            TimerLbl.Text = seconds.ToString();
            score = 0;
            ScoreLbl.Text = score.ToString();
            combo = 0;
            ComboLbl.Text = combo.ToString();
            maxCombo = 0;
            begin = false;
            end = false;
            this.BackColor = Color.LightGray;
            if (!constDiff)
            {
                level = 0;
            }

            GameLbl.Visible = false;
            MainMenuPanel.Visible = false;
            MainMenuPanel.Enabled = false;
            SettingsPanel.Visible = false;
            SettingsPanel.Enabled = false;
            GameOverPanel.Visible = false;
            GameOverPanel.Enabled = false;

            ScoreLbl.Visible = true;
            ComboLbl.Visible = true;
            TimerLbl.Visible = true;

            Randomize();
        }

        private void GlobalTimer()
        {
            while (seconds > 0)
            {
                Thread.Sleep(1000);
                seconds--;
                //Update form through action delegate to call TimerUpd() from initial thread
                TimerLbl.BeginInvoke(new Action(TimerUpd), null);
            }
            if (seconds == 0)
            {
                EndScreen();
            }
        }

        private void TimerUpd()
        {
            TimerLbl.Text = seconds.ToString();
        }

        private void EndScreen()
        {
            inGame = false;
            end = true;
            DownArrowPB.Invoke(new Action(() => DownArrowPB.Visible = false));
            LeftArrowPB.Invoke(new Action(() => LeftArrowPB.Visible = false));
            RightArrowPB.Invoke(new Action(() => RightArrowPB.Visible = false));
            UpArrowPB.Invoke(new Action(() => UpArrowPB.Visible = false));
            ScoreLbl.Invoke(new Action(() => ScoreLbl.Visible = false));
            ComboLbl.Invoke(new Action(() => ComboLbl.Visible = false));
            TimerLbl.Invoke(new Action(() => TimerLbl.Visible = false));

            GameOverPanel.Invoke(new Action(() => GameOverPanel.Visible = true));
            GameOverPanel.Invoke(new Action(() => GameOverPanel.Enabled = true));
        }

        private void EndEnabledChanged(object sender, EventArgs e)
        {
            ScoreTimer.Stop();
            BestLbl.Visible = false;
            FScoreLbl.Text = score.ToString();
            FComboLbl.Text = maxCombo.ToString();

            switch (startTime)
            {
                case 60:
                    LScoreLbl.Text = localScore60.ToString();
                    LComboLbl.Text = localCombo60.ToString();
                    lscoreN = localScore60;
                    lcomboN = localCombo60;
                    break;
                case 120:
                    LScoreLbl.Text = localScore120.ToString();
                    LComboLbl.Text = localCombo120.ToString();
                    lscoreN = localScore120;
                    lcomboN = localCombo120;
                    break;
                case 300:
                    LScoreLbl.Text = localScore300.ToString();
                    LComboLbl.Text = localCombo300.ToString();
                    lscoreN = localScore300;
                    lcomboN = localCombo300;
                    break;
            }
            
            //Update new best combo and/or score in file
            if (score > lscoreN || maxCombo > lcomboN)
            {
                BestLbl.Visible = true;
                StreamReader newScore = new StreamReader(localPath);
                while ((line = newScore.ReadLine()) != null)
                {
                    if (line.Split(':')[0] == ("lscore" + startTime) && score > lscoreN)
                    {
                        lines.Add("lscore" + startTime + ":" + score);
                        LScoreLbl.Text = score.ToString();
                        lscoreN = score;
                    } else if (line.Split(':')[0] == ("lcombo" + startTime) && maxCombo > lcomboN)
                    {
                        lines.Add("lcombo" + startTime + ":" + maxCombo);
                        LComboLbl.Text = maxCombo.ToString();
                        lcomboN = maxCombo;
                    }
                    else
                    {
                        lines.Add(line);
                    }
                }
                newScore.Close();
                File.WriteAllLines(localPath, lines);
                lines.Clear();

                switch(startTime)
                {
                    case 60:
                        localScore60 = lscoreN;
                        localCombo60 = lcomboN;
                        break;
                    case 120:
                        localScore120 = lscoreN;
                        localCombo120 = lcomboN;
                        break;
                    case 300:
                        localScore300 = lscoreN;
                        localCombo300 = lcomboN;
                        break;
                }
            }
        }

        private bool ValidateKeys(Keys k)
        {
            switch (arrowEnabled)
            {
                case 0:
                    //Down arrow
                    if (k == Keys.Down || (char)k == c1)
                    {
                        return true;
                    }
                    break;
                case 1:
                    //Left arrow
                    if (k == Keys.Left || (char)k == c2)
                    {
                        return true;
                    }
                    break;
                case 2:
                    //Right arrow
                    if (k == Keys.Right || (char)k == c3)
                    {
                        return true;
                    }
                    break;
                case 3:
                    //Up arrow
                    if (k == Keys.Up || (char)k == c4)
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }

        private void SetSize(int x, int y)
        {
            DownArrowPB.Size = new Size(x, y);
            LeftArrowPB.Size = new Size(x, y);
            RightArrowPB.Size = new Size(x, y);
            UpArrowPB.Size = new Size(x, y);
        }

        private void RndXYMax()
        {
            Random rng = new Random();
            //max range random x any y values
            rndX = (rng.Next() % (1024 - 100) + 5); //Random x and y vals that stay on screen and away from edges
            rndY = (rng.Next() % (768 - 170) + 50); //range 923x597
        }

        private void Randomize()
        {
            Random rng = new Random();
            arrowEnabled = rng.Next() % 4;
            
            switch(level)
            {
                case 0:
                    ScoreTimer.Interval = 1000;
                    SetSize(75, 75);
                    rndX = (rng.Next() % 299 + 299);
                    rndY = (rng.Next() % 462 + 100); //range 461x298
                    break;
                case 1:
                    ScoreTimer.Interval = 950;
                    SetSize(75, 75);
                    rndX = (rng.Next() % 299 + 299); 
                    rndY = (rng.Next() % 462 + 100); //range 461x298
                    break;
                case 2:
                    ScoreTimer.Interval = 900;
                    SetSize(50, 50);
                    rndX = (rng.Next() % 514 + 225); 
                    rndY = (rng.Next() % 333 + 89); //range 513x332
                    break;
                case 3:
                    ScoreTimer.Interval = 850;
                    SetSize(50, 50);
                    rndX = (rng.Next() % 616 + 150);
                    rndY = (rng.Next() % 399 + 75); //range 615x398
                    break;
                case 4:
                    ScoreTimer.Interval = 800;
                    SetSize(37, 37);
                    rndX = (rng.Next() % 770 + 75);
                    rndY = (rng.Next() % 499 + 61); //range 769x498
                    break;
                case 5:
                    ScoreTimer.Interval = 750;
                    SetSize(37, 37);
                    RndXYMax();
                    break;
                case 6:
                    ScoreTimer.Interval = 700;
                    SetSize(31, 31);
                    RndXYMax();
                    break;
                case 7:
                    ScoreTimer.Interval = 650;
                    SetSize(31, 31);
                    RndXYMax();
                    break;
                case 8:
                    ScoreTimer.Interval = 600;
                    SetSize(25, 25);
                    RndXYMax();
                    break;
                case 9:
                    ScoreTimer.Interval = 550;
                    SetSize(25, 25);
                    RndXYMax();
                    break;
                case 10:
                    ScoreTimer.Interval = 500;
                    SetSize(20, 20);
                    RndXYMax();
                    break;
            }

            switch (arrowEnabled)
            {
                case 0:
                    DownArrowPB.Location = new Point(rndX, rndY);
                    DownArrowPB.Visible = true;
                    LeftArrowPB.Visible = false;
                    RightArrowPB.Visible = false;
                    UpArrowPB.Visible = false;
                    break;
                case 1:
                    LeftArrowPB.Location = new Point(rndX, rndY);
                    DownArrowPB.Visible = false;
                    LeftArrowPB.Visible = true;
                    RightArrowPB.Visible = false;
                    UpArrowPB.Visible = false;
                    break;
                case 2:
                    RightArrowPB.Location = new Point(rndX, rndY);
                    DownArrowPB.Visible = false;
                    LeftArrowPB.Visible = false;
                    RightArrowPB.Visible = true;
                    UpArrowPB.Visible = false;
                    break;
                case 3:
                    UpArrowPB.Location = new Point(rndX, rndY);
                    DownArrowPB.Visible = false;
                    LeftArrowPB.Visible = false;
                    RightArrowPB.Visible = false;
                    UpArrowPB.Visible = true;
                    break;
            }
        }

        private void LevelCalc(int c)
        {
            switch (c)
            {
                case 1:
                case 10:
                    level = 1;
                    break;
                case 25:
                    level = 2;
                    break;
                case 50:
                    level = 3;
                    break;
                case 75:
                    level = 4;
                    break;
                case 100:
                    level = 5;
                    break;
                case 150:
                    level = 6;
                    break;
                case 200:
                    level = 7;
                    break;
                case 250:
                    level = 8;
                    break;
                case 350:
                    level = 9;
                    break;
                case 500:
                    level = 10;
                    break;
            }
        }

        private void ScoreCalc(bool validated)
        {
            if (!constDiff)
            {
                LevelCalc(combo);
            }

            if (validated)
            {
                GoodSound.Play();
                score += 100 + (10 * (level + 1));
                combo++;
                if (combo > maxCombo)
                {
                    maxCombo = combo;
                }
            }
            else
            {
                BadSound.Play();
                score -= 100 + (10 * (level*2 + 1));
                if (score < 0)
                {
                    score = 0;
                }
                combo = 0;
            }
            ScoreLbl.Text = score.ToString();
            ComboLbl.Text = combo.ToString();
        }

        private void TimerEventProcessed(object? sender, EventArgs e)
        {
            if (!end)
            {
                ScoreTimer.Stop();
                ScoreCalc(false);
                Randomize();
                ScoreTimer.Start();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (!end && inGame)
            {
                if (!begin)
                {
                    ThreadStart threadStart = new ThreadStart(GlobalTimer);
                    Thread thread = new Thread(threadStart);
                    thread.Start();
                }
                begin = true;
                ScoreTimer.Stop();
                ScoreCalc(ValidateKeys(e.KeyCode));
                Randomize();
                ScoreTimer.Start();
            } else
            {
                switch (cUpd)
                {
                    case 0:
                        break;
                    case 1:
                        c1 = (char)e.KeyCode;
                        C1Lbl.Text = "Down / " + c1;
                        break;
                    case 2:
                        c2 = (char)e.KeyCode;
                        C2Lbl.Text = "Down / " + c2;
                        break;
                    case 3:
                        c3 = (char)e.KeyCode;
                        C3Lbl.Text = "Down / " + c3;
                        break;
                    case 4:
                        c4 = (char)e.KeyCode;
                        C4Lbl.Text = "Down / " + c4;
                        break;
                }
                cUpd = 0;
            }
        }

        private void OnClose(object sender, FormClosingEventArgs e)
        {
            if (inGame || inSettings)
            {
                e.Cancel = true;
            }
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlayBtn60_Click(object sender, EventArgs e)
        {
            GameStart(60);
        }

        private void PlayBtn120_Click(object sender, EventArgs e)
        {
            GameStart(120);
        }

        private void PlayBtn300_Click(object sender, EventArgs e)
        {
            GameStart(300);
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = true;
            SettingsPanel.Enabled = true;
            GameLbl.Visible = false;
            MainMenuPanel.Visible = false;
            MainMenuPanel.Enabled = false;
            inSettings = true;
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            GameStart(startTime);
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            ShowMenu();
        }

        private void QuitEndBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeCtrl1Btn_Click(object sender, EventArgs e)
        {
            cUpd = 1;
            C1Lbl.Text = "Down / _";
        }

        private void ChangeCtrl2Btn_Click(object sender, EventArgs e)
        {
            cUpd = 2;
            C2Lbl.Text = "Down / _";
        }

        private void ChangeCtrl3Btn_Click(object sender, EventArgs e)
        {
            cUpd = 3;
            C3Lbl.Text = "Down / _";
        }

        private void ChangeCtrl4Btn_Click(object sender, EventArgs e)
        {
            cUpd = 4;
            C4Lbl.Text = "Down / _";
        }

        private void DiffRBOn_CheckedChanged(object sender, EventArgs e)
        {
            if (DiffRBOff.Checked)
            {
                DiffSettingNUD.Enabled = false;
                constDiff = false;
            } else
            {
                DiffSettingNUD.Enabled = true;
                constDiff = true;
            }
        }

        private void ResetTopBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset local top scores?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                StreamReader scoreReset = new StreamReader(localPath);
                lines.Add("lscore60:0");
                lines.Add("lcombo60:0");
                lines.Add("lscore120:0");
                lines.Add("lcombo120:0");
                lines.Add("lscore300:0");
                lines.Add("lcombo300:0");
                temp = 0;
                while ((line = scoreReset.ReadLine()) != null)
                {
                    if (temp > 6)
                    {
                        lines.Add(line);
                    }
                    temp++;
                }
                scoreReset.Close();
                File.WriteAllLines(localPath, lines);
                lines.Clear();
            }
        }

        private void SaveSettingsBtn_Click(object sender, EventArgs e)
        {
            StreamReader checkLines = new StreamReader(localPath);
            while ((line = checkLines.ReadLine()) != null)
            {
                lines.Add(line);
            }
            checkLines.Close();
            StreamWriter setSettings = new StreamWriter(localPath, false);
            //Keep local top score and combo the same
            setSettings.WriteLine(lines[0]);
            setSettings.WriteLine(lines[1]);
            setSettings.WriteLine(lines[2]);
            setSettings.WriteLine(lines[3]);
            setSettings.WriteLine(lines[4]);
            setSettings.WriteLine(lines[5]);
            lines.Clear();
            setSettings.WriteLine("c1:" + c1);
            setSettings.WriteLine("c2:" + c2);
            setSettings.WriteLine("c3:" + c3);
            setSettings.WriteLine("c4:" + c4);
            if (constDiff)
            {
                setSettings.WriteLine("cdiff:true");
                setSettings.WriteLine("level:" + DiffSettingNUD.Value.ToString());
                level = (int)DiffSettingNUD.Value;
            }
            else
            {
                setSettings.WriteLine("cdiff:false");
                setSettings.WriteLine("level:1");
            }
            setSettings.Close();
            ShowMenu();
        }
    }
}