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
    public partial class Form1 : Form
    {
        Downloader youtubedl;
        string debugLog;
        string link;
        string folderToSave = "";
        bool linkVerified = false;

        public Form1()
        {
            InitializeComponent();
            InitialCheck();
        }

        private void InitialCheck()
        {
            // Initial check for youtube-dl program
            UpdateStatusLabel("Checking for youtube-dl.exe in current directory...");
            string youtubeDLCurrentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "youtube-dl.exe");
            if (File.Exists(youtubeDLCurrentDirectory))
            {
                youTubeDLLocation.Text = youtubeDLCurrentDirectory;
                UpdateStatusLabel("Found youtube-dl.exe, verifying if program works...");
                youtubedl_importer(youtubeDLCurrentDirectory);
                if (youtubedl.ProgramTest())
                {
                    groupBox1.Enabled = true;
                    UpdateStatusLabel("Verified youtube-dl.exe, program READY");
                }
                else { UpdateStatusLabel("Verification failed, please specify another youtube-dl.exe"); }
            }
            else { UpdateStatusLabel("Could not find youtube-dl.exe in current directory."); }
        }

        private void browseYouTubeDL_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "youtube-dl Application (*.exe)|*.exe";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                youTubeDLLocation.Text = filePath;
                UpdateStatusLabel("Found youtube-dl.exe, verifying if program works...");
                youtubedl_importer(filePath);
                if (youtubedl.ProgramTest())
                {
                    groupBox1.Enabled = true;
                    UpdateStatusLabel("Verified youtube-dl.exe, program READY");
                }
                else { UpdateStatusLabel("Verification failed, please specify another youtube-dl.exe"); }
            }
        }

        private void saveLocationBrowse_Click(object sender, EventArgs e)
        {
            //if (folderToSave != "")
            //{
            //    folderBrowserDialog1.SelectedPath = folderToSave;
            //}
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderToSave = folderBrowserDialog1.SelectedPath;
                textBox2.Text = folderToSave;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Debug Menu and full command line access
            this.Hide();
            var debugForm = new DebugMenu();
            debugForm.ShowDialog();
            this.Close();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            // Open Logs but HOW?

        }

        private void checkLinkButton_Click(object sender, EventArgs e)
        {
            checkLinkButton.Enabled = false;
            UpdateProgressBar(50);
            link = textBox1.Text;
            qualitySelectorText.Text = "Quality Selector: For Link (" + link + ")";
            UpdateStatusLabel("Checking Link...");
            
            Update();

            string output = youtubedl.CheckLink(link);
            youtube_dl_Output.Text = output;

            linkVerified = true;
            checkLinkButton.Enabled = true;
            downloadButton.Enabled = true;
            UpdateStatusLabel("Link checked. Program READY");
            UpdateProgressBar(100);
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            downloadButton.Enabled = false;
            checkLinkButton.Enabled = false;

            // Write code to create format string
            string formatToDownload = "best";

            youtubedl.DownloadLink(link, formatToDownload, folderToSave);
        }

        private void youtubedl_importer(string location)
        {
            // Creating new youtube-dl object
            youtubedl = new Downloader(location) { };
        }

        private void UpdateStatusLabel(string textToUpdate)
        {
            debugLog += textToUpdate;
            toolStripStatusLabel1.Text = "Status: " + textToUpdate;
        }

        private void UpdateProgressBar(int percentage)
        {
            toolStripProgressBar1.Value = percentage;
        }

        private void UpdateFormatList(string rawOutputDump)
        {
            
        }
    }
}
