using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace YouTubeDL_QualityGUI
{
    public partial class DebugMenu : Form
    {
        Downloader youtubedl;

        public DebugMenu()
        {
            InitializeComponent();
            // DEBUG MENU to test pipe between this program and YouTubeDL
            InitialCheck();
        }

        public void InitialCheck()
        {
            string youtubeDLCurrentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "youtube-dl.exe");
            if (File.Exists(youtubeDLCurrentDirectory))
            {
                youtubedl_importer(youtubeDLCurrentDirectory);
                if (youtubedl.ProgramTest())
                {
                    youTubeDLLocation.Text = youtubeDLCurrentDirectory;
                    addLineToTextBox("DEBUG: Found youtube-dl.exe in current directory");
                }
            }
        }

        private void browseYouTubeDL_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "youtube-dl Application (*.exe)|*.exe";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                youtubedl_importer(openFileDialog1.FileName);
                if (youtubedl.ProgramTest())
                {
                    youTubeDLLocation.Text = openFileDialog1.FileName;
                    addLineToTextBox("DEBUG: Test complete, detected youtube-dl.exe");
                }
                else
                {
                    addLineToTextBox("DEBUG: Could not detect youtube-dl.exe");
                }
            }
        }

        private void addLineToTextBox(string lineToAdd)
        {
            textBox1.AppendText(lineToAdd);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Enabled = false;
                textBox1.AppendText(youtubedl.CustomCommand(textBox2.Text));
                textBox2.Clear();
                textBox2.Enabled = true;
            }
        }

        private void youtubedl_importer(string location)
        {
            // Creating new youtube-dl object
            youtubedl = new Downloader(location) { };
        }
    }
}
