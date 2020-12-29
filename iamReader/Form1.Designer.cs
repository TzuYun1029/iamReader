namespace iamReader
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
            this.components = new System.ComponentModel.Container();
>>>>>>> 介面設計雛型完成、章節按鈕生成
=======
>>>>>>> 章節按鈕生成後可以滾動，界面更新
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
>>>>>>> 版面設計、選擇章節
            this.WebsiteTextBox = new System.Windows.Forms.TextBox();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.DarkModeButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.NovelTextBox = new System.Windows.Forms.TextBox();
            this.ChapterLabel = new System.Windows.Forms.Label();
            this.FontSizeTextBox = new System.Windows.Forms.TextBox();
            this.IncreaseFontSize = new System.Windows.Forms.Button();
            this.DecreaseFontSize = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.WebsiteLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.BackToChapterButton = new System.Windows.Forms.Button();
            this.PleaseEnterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WebsiteTextBox
            // 
            this.WebsiteTextBox.Location = new System.Drawing.Point(175, 390);
            this.WebsiteTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WebsiteTextBox.Name = "WebsiteTextBox";
            this.WebsiteTextBox.Size = new System.Drawing.Size(359, 25);
            this.WebsiteTextBox.TabIndex = 0;
            // 
            // DownloadButton
            // 
            this.DownloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(92)))), ((int)(((byte)(65)))));
            this.DownloadButton.Font = new System.Drawing.Font("細明體-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DownloadButton.ForeColor = System.Drawing.Color.Linen;
            this.DownloadButton.Location = new System.Drawing.Point(457, 429);
            this.DownloadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(77, 34);
            this.DownloadButton.TabIndex = 1;
            this.DownloadButton.Text = "下載";
            this.DownloadButton.UseVisualStyleBackColor = false;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // DarkModeButton
            // 
            this.DarkModeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(92)))), ((int)(((byte)(65)))));
            this.DarkModeButton.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DarkModeButton.ForeColor = System.Drawing.Color.White;
            this.DarkModeButton.Location = new System.Drawing.Point(230, 9);
            this.DarkModeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DarkModeButton.Name = "DarkModeButton";
            this.DarkModeButton.Size = new System.Drawing.Size(101, 42);
            this.DarkModeButton.TabIndex = 3;
            this.DarkModeButton.Text = "深色模式";
            this.DarkModeButton.UseVisualStyleBackColor = false;
            this.DarkModeButton.Click += new System.EventHandler(this.DarkModeButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(92)))), ((int)(((byte)(65)))));
            this.HomeButton.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(435, 9);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(99, 42);
            this.HomeButton.TabIndex = 4;
            this.HomeButton.Text = "回主頁";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // NovelTextBox
            // 
            this.NovelTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NovelTextBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NovelTextBox.Location = new System.Drawing.Point(12, 64);
            this.NovelTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NovelTextBox.MinimumSize = new System.Drawing.Size(300, 600);
            this.NovelTextBox.Name = "NovelTextBox";
            this.NovelTextBox.Size = new System.Drawing.Size(529, 27);
            this.NovelTextBox.TabIndex = 6;
            // 
            // ChapterLabel
            // 
            this.ChapterLabel.AutoSize = true;
            this.ChapterLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChapterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChapterLabel.Location = new System.Drawing.Point(12, 9);
            this.ChapterLabel.MaximumSize = new System.Drawing.Size(199, 30);
            this.ChapterLabel.MinimumSize = new System.Drawing.Size(199, 30);
            this.ChapterLabel.Name = "ChapterLabel";
            this.ChapterLabel.Size = new System.Drawing.Size(199, 30);
            this.ChapterLabel.TabIndex = 7;
            this.ChapterLabel.Text = "章節";
            this.ChapterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FontSizeTextBox
            // 
            this.FontSizeTextBox.Location = new System.Drawing.Point(548, 20);
            this.FontSizeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FontSizeTextBox.Name = "FontSizeTextBox";
            this.FontSizeTextBox.Size = new System.Drawing.Size(48, 25);
            this.FontSizeTextBox.TabIndex = 8;
            // 
            // IncreaseFontSize
            // 
            this.IncreaseFontSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(92)))), ((int)(((byte)(65)))));
            this.IncreaseFontSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IncreaseFontSize.Location = new System.Drawing.Point(617, 20);
            this.IncreaseFontSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IncreaseFontSize.Name = "IncreaseFontSize";
            this.IncreaseFontSize.Size = new System.Drawing.Size(37, 22);
            this.IncreaseFontSize.TabIndex = 9;
            this.IncreaseFontSize.Text = "+";
            this.IncreaseFontSize.UseVisualStyleBackColor = false;
            this.IncreaseFontSize.Click += new System.EventHandler(this.IncreaseFontSize_Click);
            // 
            // DecreaseFontSize
            // 
            this.DecreaseFontSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(92)))), ((int)(((byte)(65)))));
            this.DecreaseFontSize.ForeColor = System.Drawing.Color.White;
            this.DecreaseFontSize.Location = new System.Drawing.Point(661, 20);
            this.DecreaseFontSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DecreaseFontSize.Name = "DecreaseFontSize";
            this.DecreaseFontSize.Size = new System.Drawing.Size(37, 22);
            this.DecreaseFontSize.TabIndex = 10;
            this.DecreaseFontSize.Text = "-";
            this.DecreaseFontSize.UseVisualStyleBackColor = false;
            this.DecreaseFontSize.Click += new System.EventHandler(this.DecreaseFontSize_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(92)))), ((int)(((byte)(65)))));
            this.ExitButton.Font = new System.Drawing.Font("細明體-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ExitButton.ForeColor = System.Drawing.Color.Linen;
            this.ExitButton.Location = new System.Drawing.Point(289, 507);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(140, 48);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "離開";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // WebsiteLabel
            // 
            this.WebsiteLabel.AutoSize = true;
            this.WebsiteLabel.BackColor = System.Drawing.Color.Transparent;
            this.WebsiteLabel.Font = new System.Drawing.Font("細明體-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WebsiteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(92)))), ((int)(((byte)(65)))));
            this.WebsiteLabel.Location = new System.Drawing.Point(171, 352);
            this.WebsiteLabel.Name = "WebsiteLabel";
            this.WebsiteLabel.Size = new System.Drawing.Size(110, 24);
            this.WebsiteLabel.TabIndex = 15;
            this.WebsiteLabel.Text = "輸入網址";
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(92)))), ((int)(((byte)(65)))));
            this.StartButton.Font = new System.Drawing.Font("細明體-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StartButton.ForeColor = System.Drawing.Color.Linen;
            this.StartButton.Location = new System.Drawing.Point(289, 445);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(140, 48);
            this.StartButton.TabIndex = 12;
            this.StartButton.Text = "開始";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // BackToChapterButton
            // 
            this.BackToChapterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(92)))), ((int)(((byte)(65)))));
            this.BackToChapterButton.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BackToChapterButton.ForeColor = System.Drawing.Color.White;
            this.BackToChapterButton.Location = new System.Drawing.Point(337, 9);
            this.BackToChapterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackToChapterButton.Name = "BackToChapterButton";
            this.BackToChapterButton.Size = new System.Drawing.Size(92, 42);
            this.BackToChapterButton.TabIndex = 16;
            this.BackToChapterButton.Text = "回章節";
            this.BackToChapterButton.UseVisualStyleBackColor = false;
            this.BackToChapterButton.Click += new System.EventHandler(this.BackToChapterButton_Click);
            // 
            // PleaseEnterLabel
            // 
            this.PleaseEnterLabel.AutoSize = true;
            this.PleaseEnterLabel.BackColor = System.Drawing.Color.Transparent;
            this.PleaseEnterLabel.Font = new System.Drawing.Font("文鼎新明體L", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PleaseEnterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PleaseEnterLabel.Location = new System.Drawing.Point(175, 429);
            this.PleaseEnterLabel.Name = "PleaseEnterLabel";
            this.PleaseEnterLabel.Size = new System.Drawing.Size(109, 20);
            this.PleaseEnterLabel.TabIndex = 17;
            this.PleaseEnterLabel.Text = "請輸入網址";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 953);
            this.Controls.Add(this.PleaseEnterLabel);
            this.Controls.Add(this.BackToChapterButton);
            this.Controls.Add(this.WebsiteLabel);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.DecreaseFontSize);
            this.Controls.Add(this.IncreaseFontSize);
            this.Controls.Add(this.FontSizeTextBox);
            this.Controls.Add(this.ChapterLabel);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.DarkModeButton);
            this.Controls.Add(this.WebsiteTextBox);
            this.Controls.Add(this.NovelTextBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iamReader";
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.WordSizeTrackBar)).EndInit();
=======
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(590, 348);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
>>>>>>> new the html catcher_v1 (with content only)
=======
>>>>>>> Combine the interface and function
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.TextBox WebsiteTextBox;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Button DarkModeButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.TextBox NovelTextBox;
        private System.Windows.Forms.Label ChapterLabel;
<<<<<<< HEAD
        private System.Windows.Forms.TrackBar WordSizeTrackBar;
=======
        private System.Windows.Forms.TextBox textBox1;
>>>>>>> new the html catcher_v1 (with content only)
=======
        private System.Windows.Forms.TextBox FontSizeTextBox;
        private System.Windows.Forms.Button IncreaseFontSize;
        private System.Windows.Forms.Button DecreaseFontSize;
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> Combine the interface and function
=======
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label WebsiteLabel;
        private System.Windows.Forms.Button StartButton;
>>>>>>> 版面設計、選擇章節
=======
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label WebsiteLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button BackToChapterButton;
<<<<<<< HEAD
>>>>>>> 介面設計雛型完成、章節按鈕生成
=======
        private System.Windows.Forms.Label PleaseEnterLabel;
>>>>>>> 章節按鈕生成後可以滾動，界面更新
    }
}

