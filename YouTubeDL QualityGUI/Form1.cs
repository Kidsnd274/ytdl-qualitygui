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
using System.Diagnostics;

namespace YouTubeDL_QualityGUI
{
    public partial class Form1 : Form
    {
        Downloader youtubedl;

        public Form1()
        {
            InitializeComponent();
            // Initial check for youtube-dl program
            string youtubeDLCurrentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "youtube-dl.exe");
            if (File.Exists(youtubeDLCurrentDirectory))
            {
                if (youtubedl_test(youtubeDLCurrentDirectory))
                {
                    youtubedl_importer(youtubeDLCurrentDirectory);
                    groupBox1.Enabled = true;
                }
            }
        }

        private void browseYouTubeDL_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "youtube-dl Application (*.exe)|*.exe";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
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

        private bool youtubedl_test(string location)
        {
            // Test for youtube-dl program
            StringBuilder outputBuilder;
            ProcessStartInfo processStartInfo;
            Process youtubedlProcess;

            outputBuilder = new StringBuilder();

            processStartInfo = new ProcessStartInfo();
            processStartInfo.CreateNoWindow = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.UseShellExecute = false;
            processStartInfo.Arguments = "-h";
            processStartInfo.FileName = location;

            youtubedlProcess = new Process();
            youtubedlProcess.StartInfo = processStartInfo;
            // enable raising events because Process does not raise events by default
            youtubedlProcess.EnableRaisingEvents = true;
            // attach the event handler for OutputDataReceived before starting the process
            youtubedlProcess.OutputDataReceived += new DataReceivedEventHandler
            (
                delegate (object sender, DataReceivedEventArgs e)
                {
                    // append the new data to the data already read-in
                    outputBuilder.Append(e.Data);
                }
            );
            // start the process
            // then begin asynchronously reading the output
            // then wait for the process to exit
            // then cancel asynchronously reading the output
            youtubedlProcess.Start();
            youtubedlProcess.BeginOutputReadLine();
            youtubedlProcess.WaitForExit();
            youtubedlProcess.CancelOutputRead();

            // use the output
            string output = outputBuilder.ToString();
            if (output.Contains("Usage: youtube-dl.exe"))
            {
                return true;
            }
            else { return false; }
        }

        private void youtubedl_importer(string location)
        {
            // Creating new youtube-dl object
            youtubedl = new Downloader() { };
        }

        private void UpdateStatusLabel(string textToUpdate)
        {
            toolStripStatusLabel1.Text = "Status: " + textToUpdate;
        }
    }
}
