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
        public DebugMenu()
        {
            InitializeComponent();
            // DEBUG MENU to test pipe between this program and YouTubeDL

        }

        private void browseYouTubeDL_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "youtube-dl Application (*.exe)|*.exe";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (youtubedl_test(openFileDialog1.FileName))
                {
                    addLineToTextBox("DEBUG: Test complete, detected youtube-dl.exe");
                }
                else
                {
                    addLineToTextBox("Could not detect youtube-dl.exe");
                }
            }
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
            addLineToTextBox(output);
            if (output.Contains("Usage: youtube-dl.exe"))
            {
                return true;
            }
            else { return false; }
        }

        private void addLineToTextBox(string lineToAdd)
        {
            textBox1.Text += lineToAdd;
            textBox1.Update();
        }
    }
}
