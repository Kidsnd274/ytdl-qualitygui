using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace YouTubeDL_QualityGUI
{
    class Downloader
    {
        /* Main Object to send inputs and receive outputs to the main YouTube DL Program */
        private string youtubedlLocation;

        StringBuilder outputBuilder;
        ProcessStartInfo processStartInfo;
        Process youtubedlProcess;

        public Downloader(string import_youtubedlLocation)
        {
            // Initialize youtube-dl object
            youtubedlLocation = import_youtubedlLocation;

            outputBuilder = new StringBuilder();

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
            if (folderToSave == "")
            {
                processStartInfo.Arguments = "-f " + formatToDownload + " \"" + link + "\"";
            }
            else
            {
                string fileToSave = folderToSave + @"\%(title)s.%(ext)s";
                processStartInfo.Arguments = "-o \"" + fileToSave + " -f " + formatToDownload + " \"" + link + "\"";
            }
            youtubedlProcess.Start();
            youtubedlProcess.BeginOutputReadLine();
            youtubedlProcess.WaitForExit();
            youtubedlProcess.CancelOutputRead();

            string output = outputBuilder.ToString();

            return output;
        }
    }
}
