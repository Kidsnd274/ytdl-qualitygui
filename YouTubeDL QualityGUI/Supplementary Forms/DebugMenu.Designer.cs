namespace YouTubeDL_QualityGUI
{
    partial class DebugMenu
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
            this.browseYouTubeDL = new System.Windows.Forms.Button();
            this.youTubeDLLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // browseYouTubeDL
            // 
            this.browseYouTubeDL.Location = new System.Drawing.Point(607, 33);
            this.browseYouTubeDL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browseYouTubeDL.Name = "browseYouTubeDL";
            this.browseYouTubeDL.Size = new System.Drawing.Size(100, 28);
            this.browseYouTubeDL.TabIndex = 6;
            this.browseYouTubeDL.Text = "Browse";
            this.browseYouTubeDL.UseVisualStyleBackColor = true;
            this.browseYouTubeDL.Click += new System.EventHandler(this.browseYouTubeDL_Click);
            // 
            // youTubeDLLocation
            // 
            this.youTubeDLLocation.Location = new System.Drawing.Point(161, 36);
            this.youTubeDLLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.youTubeDLLocation.Name = "youTubeDLLocation";
            this.youTubeDLLocation.ReadOnly = true;
            this.youTubeDLLocation.Size = new System.Drawing.Size(436, 22);
            this.youTubeDLLocation.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "youtube-dl Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "DEBUG MODE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 68);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(684, 438);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 514);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(684, 22);
            this.textBox2.TabIndex = 9;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DebugMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 554);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.browseYouTubeDL);
            this.Controls.Add(this.youTubeDLLocation);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DebugMenu";
            this.Text = "YouTubeDL Quality GUI (DEBUG MENU)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseYouTubeDL;
        private System.Windows.Forms.TextBox youTubeDLLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}