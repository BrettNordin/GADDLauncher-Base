using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SphubCore;
using CmlLib.Launcher;
using System.Diagnostics;
using System.Threading;

namespace GADD_Application
{
    public partial class Console : Form
    {
        public static Console Logger;
        public static Process proc;

        public Console()
        {
            InitializeComponent();
            Logger = this;
        }

        public static void WriteLine(string text)
        {
            Logger.Invoke((MethodInvoker)delegate
            {
                Logger.RTB.AppendText(text);
                Logger.RTB.AppendText(Environment.NewLine);
            });
        }

        private void Export_Click(object sender, EventArgs e)
        {
        }

        private void KillEngine_Click(object sender, EventArgs e)
        {
            proc.Kill();
            KillEngine.Enabled = false;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View(false);
        }

        public static void KillEngineState(bool tf)
        {
            Logger.Invoke((MethodInvoker)delegate
            {
                Console.Logger.KillEngine.Visible = tf;
            });
        }

        public static void View(bool state)
        {
            Logger.Invoke((MethodInvoker)delegate
            {
                Logger.Visible = state;
            });
        }
    }
}