using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CmlLib;
using MetroFramework.Interfaces;
using MetroFramework.Forms;
using MetroFramework;
using GADD_Application.Forms;

namespace GADD_Application
{
    public static class NativeMethods
    {
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPhysicallyInstalledSystemMemory(out long TotalMemoryInKilobytes);
    }

    public partial class MCSettings : UserControl
    {
        public MCSettings()
        {
            try
            {
                InitializeComponent();
                NativeMethods.GetPhysicallyInstalledSystemMemory(out long memKb);
                int mem = int.Parse(memKb.ToString()) / 1024;
                trackBar1.Maximum = mem;
                trackBar1.Value = Properties.Settings.Default.ram;
                label2.Text = trackBar1.Value.ToString() + " MB";
                args.Text = Properties.Settings.Default.javargs;
                textBox1.Text = Properties.Settings.Default.mclocation;
            }
            catch (Exception errormessage)
            {
                using (SphubCore.ErrorWindow ew = new SphubCore.ErrorWindow(errormessage))
                {
                    ew.Show();
                }
            }
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ram = trackBar1.Value;
            Properties.Settings.Default.Save();
            label2.Text = trackBar1.Value.ToString() + " MB";
        }

        private void Args_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.javargs = args.Text;
            Properties.Settings.Default.Save();
        }

        public int debug = 1;

        private void Button1_Click(object sender, EventArgs e)
        {
            if (debug == 1)
            {
                debug = 0;
                Launch2.Debug(1);
                Launch2.l2.Focus();
            }
            else
            {
                debug = 1;
                Launch2.Debug(0);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.version = "";
            Properties.Settings.Default.Save();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SphubCore.ReportUploader rp = new SphubCore.ReportUploader(MCHandler.mclocation + "/logs/" + "debug.log", Properties.Settings.Default.username + "-Debug.log"))
                {
                    rp.ShowDialog();
                }
                using (SphubCore.ReportUploader rp1 = new SphubCore.ReportUploader(MCHandler.mclocation + "/logs/" + "latest.log", Properties.Settings.Default.username + "-Latest.log"))
                {
                    rp1.ShowDialog();
                }
            }
            catch (Exception errormessage)
            {
                using (SphubCore.ErrorWindow ew = new SphubCore.ErrorWindow(errormessage))
                {
                    ew.Show();
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.mclocation = folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.Save();
                textBox1.Text = Properties.Settings.Default.mclocation;
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Console.View(true);
        }

        private void MetroButton4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.password = "";
            Properties.Settings.Default.Save();
            Launch2.l2.SwitchWindows(11);
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            using (diagnostics about = new diagnostics())
            {
                _ = about.ShowDialog();
            }
        }
    }
}