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
            this.browseYouTubeDL.Location = new System.Drawing.Point(455, 27);
            this.browseYouTubeDL.Name = "browseYouTubeDL";
            this.browseYouTubeDL.Size = new System.Drawing.Size(75, 23);
            this.browseYouTubeDL.TabIndex = 6;
            this.browseYouTubeDL.Text = "Browse";
            this.browseYouTubeDL.UseVisualStyleBackColor = true;
            this.browseYouTubeDL.Click += new System.EventHandler(this.browseYouTubeDL_Click);
            // 
            // youTubeDLLocation
            // 
            this.youTubeDLLocation.Location = new System.Drawing.Point(121, 29);
            this.youTubeDLLocation.Name = "youTubeDLLocation";
            this.youTubeDLLocation.ReadOnly = true;
            this.youTubeDLLocation.Size = new System.Drawing.Size(328, 20);
            this.youTubeDLLocation.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "youtube-dl Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "DEBUG MODE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 55);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(514, 357);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 418);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(514, 20);
            this.textBox2.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DebugMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.browseYouTubeDL);
            this.Controls.Add(this.youTubeDLLocation);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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