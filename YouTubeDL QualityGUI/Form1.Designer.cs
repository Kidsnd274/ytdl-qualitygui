namespace YouTubeDL_QualityGUI
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.youTubeDLLocation = new System.Windows.Forms.TextBox();
            this.browseYouTubeDL = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.qualitySelectorText = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.youtube_dl_Output = new System.Windows.Forms.TextBox();
            this.checkLinkButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.saveLocationBrowse = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioOnlyBox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "youtube-dl Location:";
            this.label1.DoubleClick += new System.EventHandler(this.label1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 486);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(542, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Status: ";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(112, 16);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "youTubeDLFileDialog1";
            // 
            // youTubeDLLocation
            // 
            this.youTubeDLLocation.Location = new System.Drawing.Point(118, 21);
            this.youTubeDLLocation.Name = "youTubeDLLocation";
            this.youTubeDLLocation.ReadOnly = true;
            this.youTubeDLLocation.Size = new System.Drawing.Size(328, 20);
            this.youTubeDLLocation.TabIndex = 2;
            // 
            // browseYouTubeDL
            // 
            this.browseYouTubeDL.Location = new System.Drawing.Point(452, 19);
            this.browseYouTubeDL.Name = "browseYouTubeDL";
            this.browseYouTubeDL.Size = new System.Drawing.Size(75, 23);
            this.browseYouTubeDL.TabIndex = 3;
            this.browseYouTubeDL.Text = "Browse";
            this.browseYouTubeDL.UseVisualStyleBackColor = true;
            this.browseYouTubeDL.Click += new System.EventHandler(this.browseYouTubeDL_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.audioOnlyBox);
            this.groupBox1.Controls.Add(this.downloadButton);
            this.groupBox1.Controls.Add(this.qualitySelectorText);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.youtube_dl_Output);
            this.groupBox1.Controls.Add(this.checkLinkButton);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 411);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Downloader";
            // 
            // downloadButton
            // 
            this.downloadButton.Enabled = false;
            this.downloadButton.Location = new System.Drawing.Point(437, 272);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(75, 23);
            this.downloadButton.TabIndex = 6;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // qualitySelectorText
            // 
            this.qualitySelectorText.AutoSize = true;
            this.qualitySelectorText.Location = new System.Drawing.Point(6, 36);
            this.qualitySelectorText.Name = "qualitySelectorText";
            this.qualitySelectorText.Size = new System.Drawing.Size(84, 13);
            this.qualitySelectorText.TabIndex = 5;
            this.qualitySelectorText.Text = "Quality Selector:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HorizontalScrollbar = true;
            this.checkedListBox1.Location = new System.Drawing.Point(9, 52);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(503, 214);
            this.checkedListBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "youtube-dl Output:";
            // 
            // youtube_dl_Output
            // 
            this.youtube_dl_Output.Location = new System.Drawing.Point(9, 301);
            this.youtube_dl_Output.Multiline = true;
            this.youtube_dl_Output.Name = "youtube_dl_Output";
            this.youtube_dl_Output.ReadOnly = true;
            this.youtube_dl_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.youtube_dl_Output.Size = new System.Drawing.Size(503, 104);
            this.youtube_dl_Output.TabIndex = 3;
            // 
            // checkLinkButton
            // 
            this.checkLinkButton.Location = new System.Drawing.Point(437, 11);
            this.checkLinkButton.Name = "checkLinkButton";
            this.checkLinkButton.Size = new System.Drawing.Size(75, 23);
            this.checkLinkButton.TabIndex = 2;
            this.checkLinkButton.Text = "Check";
            this.checkLinkButton.UseVisualStyleBackColor = true;
            this.checkLinkButton.Click += new System.EventHandler(this.checkLinkButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Link:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Save Location:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(328, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "(leave blank to save at current directory)";
            // 
            // saveLocationBrowse
            // 
            this.saveLocationBrowse.Location = new System.Drawing.Point(452, 43);
            this.saveLocationBrowse.Name = "saveLocationBrowse";
            this.saveLocationBrowse.Size = new System.Drawing.Size(75, 23);
            this.saveLocationBrowse.TabIndex = 8;
            this.saveLocationBrowse.Text = "Browse";
            this.saveLocationBrowse.UseVisualStyleBackColor = true;
            this.saveLocationBrowse.Click += new System.EventHandler(this.saveLocationBrowse_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // audioOnlyBox
            // 
            this.audioOnlyBox.AutoSize = true;
            this.audioOnlyBox.Location = new System.Drawing.Point(327, 276);
            this.audioOnlyBox.Name = "audioOnlyBox";
            this.audioOnlyBox.Size = new System.Drawing.Size(107, 17);
            this.audioOnlyBox.TabIndex = 10;
            this.audioOnlyBox.Text = "Show Audio Only";
            this.audioOnlyBox.UseVisualStyleBackColor = true;
            this.audioOnlyBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 508);
            this.Controls.Add(this.saveLocationBrowse);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.browseYouTubeDL);
            this.Controls.Add(this.youTubeDLLocation);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "YouTubeDL QualityGUI";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox youTubeDLLocation;
        private System.Windows.Forms.Button browseYouTubeDL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checkLinkButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox youtube_dl_Output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label qualitySelectorText;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button saveLocationBrowse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.CheckBox audioOnlyBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

