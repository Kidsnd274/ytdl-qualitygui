using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace YouTubeDL_QualityGUI
{
    class Downloader
    {
        /* Main Object to send inputs and receive outputs to the main YouTube DL Program */
        private string youtubedlLocation;

        StringBuilder outputBuilder = new StringBuilder();
        ProcessStartInfo processStartInfo;
        Process youtubedlProcess;

        public Downloader(string import_youtubedlLocation)
        {
            // Initialize youtube-dl object
            youtubedlLocation = import_youtubedlLocation;

            processStartInfo = new ProcessStartInfo();
            processStartInfo.CreateNoWindow = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.UseShellExecute = false;
            // processStartInfo.Arguments = "-h";
            processStartInfo.FileName = youtubedlLocation;

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
                    outputBuilder.AppendLine(e.Data);
                }
            );
        }

        public bool ProgramTest()
        {
            outputBuilder.Clear();
            processStartInfo.Arguments = "-h";
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

        public string CheckLink(string link)
        {
            outputBuilder.Clear();
            processStartInfo.Arguments = "-F \"" + link + "\"";

            youtubedlProcess.Start();
            youtubedlProcess.BeginOutputReadLine();
            youtubedlProcess.WaitForExit();
            youtubedlProcess.CancelOutputRead();

            string output = outputBuilder.ToString();

            return output;
        }

        public string DownloadLink(string link, string formatToDownload = "best", string folderToSave = "")
        {
            outputBuilder.Clear();
            if (folderToSave == "")
            {
                processStartInfo.Arguments = "-f " + formatToDownload + " \"" + link + "\"";
            }
            else
            {
                string fileToSave = folderToSave + @"\%(title)s.%(ext)s""";
                processStartInfo.Arguments = "-o \"" + fileToSave + " -f " + formatToDownload + " \"" + link + "\"";
                // MessageBox.Show("Arguments: " + processStartInfo.Arguments);
            }
            youtubedlProcess.Start();
            youtubedlProcess.BeginOutputReadLine();
            youtubedlProcess.WaitForExit();
            youtubedlProcess.CancelOutputRead();

            string output = outputBuilder.ToString();

            return output;
        }

        public string CustomCommand(string argument)
        {
            outputBuilder.Clear();
            processStartInfo.Arguments = argument;

            youtubedlProcess.Start();
            youtubedlProcess.BeginOutputReadLine();
            youtubedlProcess.WaitForExit();
            youtubedlProcess.CancelOutputRead();

            string output = outputBuilder.ToString();

            return output;
        }
    }
}
