using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTubeDL_QualityGUI
{
    public partial class DebugLogDialog : Form
    {
        public DebugLogDialog()
        {
            InitializeComponent();
        }

        public void UpdateDialog(string newLogs)
        {
            textBox1.Text = newLogs;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();
        }
    }
}
