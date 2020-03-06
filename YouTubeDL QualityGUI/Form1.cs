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
using Microsoft.WindowsAPICodePack.Dialogs;

namespace YouTubeDL_QualityGUI
{
    public partial class Form1 : Form
    {
        Downloader youtubedl;
        DebugLogDialog debugLogDialog = new DebugLogDialog();

        string debugLog;
        string link;
        string checkOutput;
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
            CommonOpenFileDialog saveFolderDialog = new CommonOpenFileDialog();
            saveFolderDialog.IsFolderPicker = true;
            if (folderToSave == "")
            {
                saveFolderDialog.InitialDirectory = Directory.GetCurrentDirectory();
            }
            else { saveFolderDialog.InitialDirectory = folderToSave; }

            if (saveFolderDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                folderToSave = saveFolderDialog.FileName;
                textBox2.Text = folderToSave;
                UpdateStatusLabel("Save location set");
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
            debugLogDialog.ShowDialog();
        }

        private void checkLinkButton_Click(object sender, EventArgs e)
        {
            checkLinkButton.Enabled = false;
            UpdateProgressBar(50);
            link = textBox1.Text;
            qualitySelectorText.Text = "Quality Selector: For Link (" + link + ")";
            UpdateStatusLabel("Checking Link...");

            checkOutput = youtubedl.CheckLink(link);
            youtube_dl_Output.Text = checkOutput;
            UpdateFormatList(checkOutput, audioOnlyBox.Checked);

            linkVerified = true;
            checkLinkButton.Enabled = true;
            downloadButton.Enabled = true;
            UpdateStatusLabel("Link checked. Program READY");
            UpdateProgressBar(100);
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            //foreach (string item in checkedListBox1.CheckedItems)
            //{
            //    MessageBox.Show(item);
            //}
            downloadButton.Enabled = false;
            checkLinkButton.Enabled = false;
            checkedListBox1.Enabled = false;
            audioOnlyBox.Enabled = false;

            string formatToDownload = "";
            // Write code to create format string
            // Checking number of listbox items
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                if (audioOnlyBox.Checked) { formatToDownload = "bestaudio"; }
                else { formatToDownload = "best"; }
            }
            else if (checkedListBox1.CheckedItems.Count > 2)
            {
                MessageBox.Show("Too many items! Please select one video + audio format each");
                downloadButton.Enabled = true;
                checkLinkButton.Enabled = true;
                checkedListBox1.Enabled = true;
                audioOnlyBox.Enabled = true;
                return;
            }
            else if (checkedListBox1.CheckedItems.Count == 1)
            {
                string ID_raw = checkedListBox1.CheckedItems[0].ToString();
                formatToDownload = ID_raw.Split()[0];
            }
            else if (checkedListBox1.CheckedItems.Count == 2)
            {
                List<string> formats = new List<string>();
                foreach (string entries in checkedListBox1.CheckedItems)
                {
                    string ID_raw = entries.ToString();
                    string ID = ID_raw.Split()[0];
                    formats.Add(ID);
                }
                formatToDownload = formats[1] + "+" + formats[0];
            }
            else 
            { 
                MessageBox.Show("Somehow you have entered the realm of nothingness and Kidsnd274 is kinda perplexed u managed to enter here");
                formatToDownload = "best";
                downloadButton.Enabled = true;
                checkLinkButton.Enabled = true;
                checkedListBox1.Enabled = true;
                audioOnlyBox.Enabled = true;
                return; 
            }
            if (audioOnlyBox.Checked) { UpdateStatusLabel("Downloading format " + formatToDownload + " with link " + link + ". Audio only"); }
            else { UpdateStatusLabel("Downloading format " + formatToDownload + " with link " + link); }
            
            UpdateProgressBar(10);
            string downloadOutput = youtubedl.DownloadLink(link, formatToDownload, folderToSave);
            youtube_dl_Output.Text += downloadOutput;
            UpdateStatusLabel("Download complete");
            UpdateProgressBar(100);

            downloadButton.Enabled = true;
            checkLinkButton.Enabled = true;
            checkedListBox1.Enabled = true;
            audioOnlyBox.Enabled = true;
        }

        private void audioOnlyBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFormatList(checkOutput, audioOnlyBox.Checked);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutQualityGUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new Supplementary_Forms.AboutBox1();
            aboutForm.ShowDialog();
        }

        private void youtubedl_importer(string location)
        {
            // Creating new youtube-dl object
            youtubedl = new Downloader(location) { };
        }

        private void UpdateStatusLabel(string textToUpdate)
        {
            string newLine = Environment.NewLine;
            debugLog += (textToUpdate + newLine);
            toolStripStatusLabel1.Text = "Status: " + textToUpdate;
            debugLogDialog.UpdateDialog(debugLog);
        }

        private void UpdateProgressBar(int percentage)
        {
            toolStripProgressBar1.Value = percentage;
        }

        private void UpdateFormatList(string rawOutputDump, bool audioOnly = false)
        {
            bool initialOutput = false;

            checkedListBox1.Items.Clear();
            string[] lines = rawOutputDump.Split(Environment.NewLine.ToCharArray());
            foreach (var entries in lines)
            {
                if (!initialOutput)
                {
                    if (entries.Contains("format") & entries.Contains("code"))
                    {
                        initialOutput = true;
                    }
                }
                else if (initialOutput)
                {
                    if (entries == "")
                    {
                        continue;
                    }
                    else
                    {
                        if (audioOnly)
                        {
                            if (entries.Contains("audio only"))
                            {
                                checkedListBox1.Items.Add(entries);
                            }
                        }
                        else
                        {
                            checkedListBox1.Items.Add(entries);
                        }
                    }
                }
            }
        }
    }
}
