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


namespace iamReader
{
        
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
<<<<<<< HEAD
<<<<<<< HEAD
            Home();
=======
            Cover();
>>>>>>> 版面設計、選擇章節
           
        }

        private void DownloadButton_Click(object sender, EventArgs e) {
            if (WebsiteTextBox.Text != " ")
                Chapter();
            else
                PleaseEnterLabel.Visible = true;
        }


        // 預設為淺色模式
        bool DarkMode = false;

        // 深色模式
        private void DarkModeButton_Click(object sender, EventArgs e) {
            // 改為淺色模式
            if (DarkMode) {
                Console.WriteLine("Turn to bright mode");
                DarkMode = false;

                var dir = Directory.GetCurrentDirectory();
                var path = Path.Combine(dir, "Background.png");
                Image Background = new Bitmap(path);
                this.BackgroundImage = Background;

                NovelTextBox.BackColor = Color.FromArgb(255, 255, 255);
                NovelTextBox.ForeColor = Color.FromArgb(119, 92, 65);

                ChapterLabel.BackColor = Color.FromArgb(255, 255, 255);
                ChapterLabel.ForeColor = Color.FromArgb(119, 92, 65);

                DarkModeButton.BackColor = Color.FromArgb(64, 64, 64);
                DarkModeButton.ForeColor = Color.FromArgb(119, 92, 65);

                HomeButton.BackColor = Color.FromArgb(64, 64, 64);
                HomeButton.ForeColor = Color.FromArgb(119, 92, 65);

                BackToChapterButton.BackColor = Color.FromArgb(64, 64, 64);
                BackToChapterButton.ForeColor = Color.FromArgb(119, 92, 65);

                IncreaseFontSize.BackColor = Color.FromArgb(64, 64, 64);
                IncreaseFontSize.ForeColor = Color.FromArgb(119, 92, 65);
                DecreaseFontSize.BackColor = Color.FromArgb(64, 64, 64);
                DecreaseFontSize.ForeColor = Color.FromArgb(119, 92, 65);

                DarkModeButton.Text = "深色模式";
            } 
            // 改為深色模式
            else {
                Console.WriteLine("Turn to dark mode");
                DarkMode = true;

                var dir = Directory.GetCurrentDirectory();
                var path = Path.Combine(dir, "BackgroundDark.png");
                Image Background = new Bitmap(path);
                this.BackgroundImage = Background;

                NovelTextBox.BackColor = Color.FromArgb(64, 64, 64);
                NovelTextBox.ForeColor = Color.FromArgb(255, 255, 255);

                ChapterLabel.BackColor = Color.FromArgb(64, 64, 64);
                ChapterLabel.ForeColor = Color.FromArgb(255, 255, 255);
                
                DarkModeButton.BackColor = Color.FromArgb(255, 255, 255);
                DarkModeButton.ForeColor = Color.FromArgb(64, 64, 64);

                HomeButton.BackColor = Color.FromArgb(255, 255, 255);
                HomeButton.ForeColor = Color.FromArgb(64, 64, 64);

                BackToChapterButton.BackColor = Color.FromArgb(255, 255, 255);
                BackToChapterButton.ForeColor = Color.FromArgb(64, 64, 64);

                IncreaseFontSize.BackColor = Color.FromArgb(255, 255, 255);
                IncreaseFontSize.ForeColor = Color.FromArgb(64, 64, 64);
                DecreaseFontSize.BackColor = Color.FromArgb(255, 255, 255);
                DecreaseFontSize.ForeColor = Color.FromArgb(64, 64, 64);

                DarkModeButton.Text = "淺色模式";
            }
        }

        // 主頁
        private void Home() {
            var dir = Directory.GetCurrentDirectory();
            var path = Path.Combine(dir, "Background.png");
            Image Background = new Bitmap(path);
            this.BackgroundImage = Background;

            StartButton.Visible = false;
            ExitButton.Visible = false;

            WebsiteLabel.Visible = true;
            WebsiteTextBox.Visible = true;
            DownloadButton.Visible = true;
            PleaseEnterLabel.Visible = false;

            NovelTextBox.Visible = false;
            DarkModeButton.Visible = false;
            BackToChapterButton.Visible = false;
            HomeButton.Visible = false;
            ChapterLabel.Visible = false;
            FontSizeTextBox.Visible = false;
            IncreaseFontSize.Visible = false;
            DecreaseFontSize.Visible = false;

            WebsiteTextBox.Text = " ";
        }

        private void Cover() {
            StartButton.Visible = true;
            ExitButton.Visible = true;

            WebsiteLabel.Visible = false;
            WebsiteTextBox.Visible = false;
            DownloadButton.Visible = false;
            PleaseEnterLabel.Visible = false;

            NovelTextBox.Visible = false;
            DarkModeButton.Visible = false;
            HomeButton.Visible = false;
            BackToChapterButton.Visible = false;
            ChapterLabel.Visible = false;
            FontSizeTextBox.Visible = false;
            IncreaseFontSize.Visible = false;
            DecreaseFontSize.Visible = false;
        }

        private void Chapter() {
            if (!DarkMode) {
                var dir = Directory.GetCurrentDirectory();
                var path = Path.Combine(dir, "Background.png");
                Image Background = new Bitmap(path);
                this.BackgroundImage = Background;
            } else {
                var dir = Directory.GetCurrentDirectory();
                var path = Path.Combine(dir, "BackgroundDark.png");
                Image Background = new Bitmap(path);
                this.BackgroundImage = Background;
            }

            GenerateChapterButton(true);
            
            StartButton.Visible = false;
            ExitButton.Visible = false;

            WebsiteLabel.Visible = false;
            WebsiteTextBox.Visible = false;
            DownloadButton.Visible = false;
            PleaseEnterLabel.Visible = false;

            NovelTextBox.Visible = false;
            DarkModeButton.Visible = false;
            BackToChapterButton.Visible = false;
            HomeButton.Visible = false;
            ChapterLabel.Visible = false;
            FontSizeTextBox.Visible = false;
            IncreaseFontSize.Visible = false;
            DecreaseFontSize.Visible = false;
        }

        // 閱讀畫面
        private async Task Read() {
            var getHtml = new GetHtml();
            string url = WebsiteTextBox.Text;
            Console.WriteLine("Download from: {0}", url);
            getHtml.Get_Website(url);
            string content = await getHtml.GetHtmlAsync();
            Console.WriteLine("Loading content");

            if (DarkMode) {
                var dir = Directory.GetCurrentDirectory();
                var path = Path.Combine(dir, "BackgroundDark.png");
                Image Background = new Bitmap(path);
                this.BackgroundImage = Background;
            } else {
                var dir = Directory.GetCurrentDirectory();
                var path = Path.Combine(dir, "Background.png");
                Image Background = new Bitmap(path);
                this.BackgroundImage = Background;
            }

            StartButton.Visible = false;
            ExitButton.Visible = false;

            WebsiteLabel.Visible = false;
            WebsiteTextBox.Visible = false;
            DownloadButton.Visible = false;
            PleaseEnterLabel.Visible = false;

            NovelTextBox.Visible = true;
            DarkModeButton.Visible = true;
            BackToChapterButton.Visible = true;
            HomeButton.Visible = true;
            ChapterLabel.Visible = true;
            FontSizeTextBox.Visible = true;
            IncreaseFontSize.Visible = true;
            DecreaseFontSize.Visible = true;

            NovelTextBox.ReadOnly = true;
            NovelTextBox.Multiline = true;
            NovelTextBox.ScrollBars = ScrollBars.Vertical;
            NovelTextBox.SelectedText = NovelTextBox.Text + "\r\n";
            NovelTextBox.ScrollToCaret();

           
            NovelTextBox.Text = content;
            NovelTextBox.SetBounds(20,50,this.Width-50,this.Height-100);

            FontSizeTextBox.Text = Convert.ToString(NovelTextBox.Font.Size);
        }

        private void OpenCloseBook(bool open) {
            
            if (open) {
                this.Width *= 2;
                this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            } else {
                this.Width /= 2;
                this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            }
        }

        // 回主頁
        private void HomeButton_Click(object sender, EventArgs e) {
            OpenCloseBook(false);
            Home();
            
        }

        private void ChapterButton_click(object sender, EventArgs e) {
            Button Button = (Button)sender;
            ChapterLabel.Text = Button.Text;
            Read();
            OpenCloseBook(true);
            GenerateChapterButton(false);
        }


        int ChapterNum = 100;
        List<Button> ChapterButtonList = new List<Button>();
        List<Panel> ChapterPanelList = new List<Panel>();
        private void GenerateChapterButton(bool Generate) {
            if (Generate) {
                Panel ChapterPanel = new Panel();
                ChapterPanel.SetBounds(10, 30, this.Width - 60, this.Height - 100);
                ChapterPanel.AutoScroll = true;
                ChapterPanel.BackColor = Color.Transparent;
                Controls.Add(ChapterPanel);
                ChapterPanelList.Add(ChapterPanel);
                int ButtonWidth =140;
                int ButtonHeight = 60;
                for (int i = 0; i < ChapterNum; i++) {
                    Button btn = new Button();
                    btn.Size = new Size(ButtonWidth, ButtonHeight);
                    int ButtonLocationX = ChapterPanel.Width / 2 - ButtonWidth / 2 + (i % 3 - 1) * (ButtonWidth + 10);
                    int ButtonLocationY = ChapterPanel.Height / 2 - ButtonHeight / 2 + (i / 3 - (ChapterNum / 3 + 1) / 2) * (ButtonHeight + 10);
                    btn.Location = new Point(ButtonLocationX, ButtonLocationY);
                    Controls.Add(btn);
                    btn.Click += new EventHandler(ChapterButton_click);
                    btn.Text = "第" + (i + 1) + "章";
                    if (!DarkMode) {
                        btn.BackColor = Color.Linen;
                        btn.ForeColor = Color.Black;
                    } else {
                        btn.BackColor = Color.FromArgb(64,64,64);
                        btn.ForeColor = Color.White;
                    }
                    btn.Font = new Font("細明體-ExtB", 12);
                    ChapterButtonList.Add(btn);
                    ChapterPanel.Controls.Add(btn);
                }
            } else {
                for (int i = 0; i < ChapterButtonList.Count; i++) {
                    ChapterButtonList[i].Dispose();
                }
                for (int i = 0; i < ChapterPanelList.Count; i++) {
                    ChapterPanelList[i].Dispose();
                }
            }
        }

        // 調整字體大小
<<<<<<< HEAD
        private void WordSizeTrackBar_Scroll(object sender, EventArgs e) {
            NovelTextBox.Font = new Font("微軟正黑體", WordSizeTrackBar.Value + 10);
=======
            
>>>>>>> new the html catcher_v1 (with content only)
=======
        private void IncreaseFontSize_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Increase font size");
            NovelTextBox.Font = new Font(NovelTextBox.Font.FontFamily, NovelTextBox.Font.Size + 1);
            FontSizeTextBox.Text = Convert.ToString(NovelTextBox.Font.Size);
        }

        private void DecreaseFontSize_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Decrease font size");
            NovelTextBox.Font = new Font(NovelTextBox.Font.FontFamily, NovelTextBox.Font.Size - 1);
            FontSizeTextBox.Text = Convert.ToString(NovelTextBox.Font.Size);
>>>>>>> Combine the interface and function
        }

        private void StartButton_Click(object sender, EventArgs e) {
            Home();
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

       

        private void BackToChapterButton_Click(object sender, EventArgs e) {
            OpenCloseBook(false);
            Chapter();
           
        }
    }
}
