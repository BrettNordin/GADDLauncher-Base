using System;
using System.Windows.Forms;
using SphubCore;
using System.Net;
using System.Diagnostics;

namespace GADD_Application
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(true);
            if (Properties.Settings.Default.mclocation == "")
            {
                Properties.Settings.Default.mclocation = Environment.GetEnvironmentVariable("appdata") + "\\.gaddcraft";
                Properties.Settings.Default.Save();
            }
            string local = System.IO.File.ReadAllText(@"version.txt");
            string release = "";
            using (WebClient wc = new WebClient())
            {
                release = wc.DownloadString("https://ixs.sphub.ca/GADD_LAUNCHER/version.txt");
            }
            if (local == release)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                try
                {
                    FontSystem.Init();
                }
                catch (Exception er)
                {
                    SphubCore.Reporting.Reporting.ER(er);
                }

                try
                {
                    Console con = new Console();
                    con.Show();
                    Console.View(false);
                    Application.Run(new Launch2());
                }
                catch (Exception er)
                {
                    SphubCore.Reporting.Reporting.ER(er);
                    //ErrorWindow ew = new ErrorWindow(errormessage);
                    // ew.Show();
                }
            }
            else
            {
                Process updater = new Process();
                updater.StartInfo.FileName = "GADD_Launcher_Updater.exe";
                updater.Start();
            }
        }
    }
}