using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CmlLib.Launcher;
using System.Threading;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;
using SphubCore;
using MetroFramework.Forms;
using GADD_Application.Classes;

namespace GADD_Application
{
    public partial class Launch2 : MetroForm
    {
        public static Launch2 l2;
        private MCHandler MHC = new MCHandler();
        public MSession session;

        public static string applet = "SPHUB_MAIL";

        public Launch2()
        {
            try
            {
                InitializeComponent();
                label1.Text = "Build: " + System.IO.File.ReadAllText(@"version.txt") + ", Connected to " + Classes.Definitions.ServerName + " Build Server";
                this.Icon = new Icon("Resources/favicon.ico");
                F_Init();
                l2 = this;
                SwitchWindows(Properties.Settings.Default.fav_men);
            }
            catch (Exception errormessage)
            {
                SphubCore.ErrorWindow ew = new SphubCore.ErrorWindow(errormessage);
                ew.Show();
            }
        }

        #region Window Switcher

        public void SwitchWindows(int id)
        {
            try
            {
                HideAllWindows();
                if (id == 0)
                {
                    HomeWindow.Visible = true;
                    this.BackColor = System.Drawing.Color.Black;
                    this.BackgroundImage = global::GADD_Application.Properties.Resources.split_logo;
                    this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                }
                //MC Login Window
                if (id == 11)
                {
                    if (GADD_Application.Properties.Settings.Default.username != "" && GADD_Application.Properties.Settings.Default.password != "")
                    {
                        if (MCHandler.AuthenticateLogin(GADD_Application.Properties.Settings.Default.username, GADD_Application.Properties.Settings.Default.password))
                        {
                            SwitchWindows(12);
                        }
                        else
                        {
                            LoginWindow.Visible = true;
                            this.BackColor = System.Drawing.Color.Black;
                            this.BackgroundImage = global::GADD_Application.Properties.Resources.Minecraft_Path_Tracing_Feature;
                            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        }
                    }
                    else
                    {
                        LoginWindow.Visible = true;
                        this.BackColor = System.Drawing.Color.Black;
                        this.BackgroundImage = global::GADD_Application.Properties.Resources.Minecraft_Path_Tracing_Feature;
                        this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    }
                }
                //MC Main Window
                if (id == 12)
                {
                    MCMainWindow.Visible = true;
                    MainWindowMC.MWMC.InitializeWindow();
                    this.BackColor = System.Drawing.Color.Black;
                    this.BackgroundImage = global::GADD_Application.Properties.Resources.Minecraft_Path_Tracing_Feature;
                    this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                }
                if (id == 21)
                {
                    mainWindowArma.Visible = true;
                    MainWindowArma.MWArma.InitializeWindow();
                    this.BackColor = System.Drawing.Color.Black;
                    this.BackgroundImage = global::GADD_Application.Properties.Resources.Liv1_Phil;
                    this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                }
            }
            catch (Exception errormessage)
            {
                SphubCore.ErrorWindow ew = new SphubCore.ErrorWindow(errormessage);
                ew.Show();
            }
        }

        public void HideAllWindows()
        {
            LoginWindow.Visible = false;
            MCMainWindow.Visible = false;
            HomeWindow.Visible = false;
            mainWindowArma.Visible = false;
        }

        #endregion Window Switcher

        #region Init/Play

        public void F_Init()
        {
            try
            {
                Minecraft.DefaultPath = Properties.Settings.Default.mclocation;
                var java = new CmlLib.Utils.MJava(Minecraft.DefaultPath + "\\runtime");
                if (!java.CheckJavaw())
                {
                    var form = new JVDWN();
                    form.Show();
                    bool iscom = false;

                    java.DownloadProgressChanged += (s, v) =>
                    {
                        form.ChangeProgress(v.ProgressPercentage);
                    };
                    java.UnzipCompleted += (t, w) =>
                    {
                        form.Close();
                        this.Show();
                        iscom = true;
                    };

                    java.DownloadJavaAsync();

                    while (!iscom)
                    {
                        Application.DoEvents();
                    }
                }
                MHC.javalocation = Minecraft.DefaultPath + "\\runtime\\bin\\javaw.exe";
            }
            catch (Exception errormessage)
            {
                SphubCore.ErrorWindow ew = new SphubCore.ErrorWindow(errormessage);
                ew.Show();
            }
        }

        public void MC_Play()
        {
            try
            {
                Debug(1);
                GaddPage.GP.ButtonStat(false);
                int update = 0;
                string localv = GADD_Application.Properties.Settings.Default.version;
                bool mcprofileinstalled = GADD_Application.Properties.Settings.Default.MCProfileInstalled;
                string versionfile;
                using (WebClient wc = new WebClient())
                {
                    versionfile = wc.DownloadString(Classes.Definitions.UpdateURL + "version.txt");
                }
                update = GADD_Application.Classes.Toolkit.VersionParser(versionfile.Split('-'), localv, versionfile);
                string pubver = versionfile.Split('-')[0];
                string fullver = versionfile;

                var th = new Thread(new ThreadStart(delegate
                {
                    Minecraft.Initialize(MCHandler.mclocation);
                    if (!Directory.Exists(MHC.version_folder))
                    {
                        Directory.CreateDirectory(MHC.version_folder);
                    }
                    if (!File.Exists(MHC.version_file))
                    {
                        using (var client = new WebClient())
                        {
                            client.DownloadFile(Classes.Definitions.UpdateURL + "original/1.12.2-forge1.12.2-14.23.5.2847.json", MCHandler.mclocation + "/" + "versions/1.12.2-forge1.12.2-14.23.5.2847/1.12.2-forge1.12.2-14.23.5.2847.json");
                        }
                    }
                    var local = MProfileInfo.GetProfilesFromLocal();
                    MProfileInfo[] versions = MProfileInfo.GetProfiles();
                    MProfile profile = MProfile.GetProfile(versions, "1.12.2-forge1.12.2-14.23.5.2847");
                    MProfile profileb = MProfile.GetProfile(versions, "1.12.2");
                    if (update != 0)
                    {
                        mcprofileinstalled = false;
                    }
                    if (!mcprofileinstalled)
                    {
                        DownloadGame(profile);
                        DownloadGame(profileb);
                        Invoke((MethodInvoker)delegate
                        {
                            GADD_Application.Properties.Settings.Default.MCProfileInstalled = true;
                            Properties.Settings.Default.Save();
                        });
                    }
                    if (update == 1)
                    {
                        DownloadModpack(pubver);
                    }
                    if (update == 2)
                    {
                        DownloadModpack(pubver);
                    }
                    if (update == 3)
                    {
                        DownloadModpack(pubver, GADD_Application.Classes.Toolkit.PublicPatchVersion());
                    }
                    Invoke((MethodInvoker)delegate
                    {
                        GADD_Application.Properties.Settings.Default.version = fullver;
                        Properties.Settings.Default.Save();
                    });
                    if (update == 0)
                    {
                        StartGame();
                    }
                }));
                th.Start();
            }
            catch (Exception errormessage)
            {
                SphubCore.Reporting.Reporting.ER(errormessage);
            }
        }

        #endregion Init/Play

        private void StartGame()
        {
            var local = MProfileInfo.GetProfilesFromLocal();
            MProfileInfo[] versions = MProfileInfo.GetProfiles();
            MProfile profile = MProfile.GetProfile(versions, "1.12.2-forge1.12.2-14.23.5.2847");
            MLaunchOption option = new MLaunchOption()
            {
                StartProfile = profile,
                JavaPath = GADD_Application.Properties.Settings.Default.mclocation + "\\runtime\\bin\\javaw.exe",
                MaximumRamMb = GADD_Application.Properties.Settings.Default.ram,
                LauncherName = "GADD",
                Session = session,
                CustomJavaParameter = Properties.Settings.Default.javargs
            };
            MLaunch launch = new MLaunch(option);
            var proc = launch.GetProcess();
            //proc.Start();
            //launch.GetProcess().Start();
            StartDebug(proc);
            //Console.ProcessLock(launch);
            Invoke((MethodInvoker)delegate
            {
                GaddPage.GP.ButtonStat(true);
            });
        }

        private void StartDebug(Process launch)
        {
            Console.Logger.Invoke((MethodInvoker)delegate
            {
                Console.KillEngineState(true);
                Console.proc = launch;
            });
            Console.WriteLine("GameStartMode : Debug");

            var process = launch;

            Console.WriteLine("Trying Write Game Args");
            try
            {
                System.IO.File.WriteAllText("launcher.txt", process.StartInfo.Arguments);
            }
            catch
            {
                Console.WriteLine("Write Game Args Failed");
            }

            Console.WriteLine("Setting up Debug Process");
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.EnableRaisingEvents = true;
            process.ErrorDataReceived += Process_ErrorDataReceived;
            process.OutputDataReceived += Process_OutputDataReceived;

            Console.WriteLine("Start Debug Process");
            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();
        }

        #region Downloader

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            output(e.Data);
        }

        private void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            output(e.Data);
        }

        private void output(string msg)
        {
            msg += "\n";
            Console.WriteLine(msg);
        }

        private void DownloadGame(MProfile profile, bool downloadResource = true)
        {
            MDownloader downloader = new MDownloader(profile);
            downloader.ChangeFile += Downloader_ChangeFile;
            downloader.DownloadAll(downloadResource);
        }

        private void DownloadModpack(string version)
        {
            try
            {
                Invoke((MethodInvoker)delegate
                {
                    GaddPage.GP.UpdateDownloadString("Now Downloading Modpack Version: " + version);
                });
                using (var client = new WebClient())
                {
                    client.DownloadProgressChanged += Wc_DownloadProgressChanged;
                    client.DownloadFileCompleted += PackDlFinished;
                    l2.Dlnotif("Fetch:" + Classes.Definitions.UpdateURL + "packfiles/" + version + "/FULL/pack.zip");
                    var url = new Uri(Classes.Definitions.UpdateURL + "packfiles/" + version + "/FULL/pack.zip");
                    client.DownloadFileAsync(url, MCHandler.mclocation + "/" + "pack.szf");
                }
            }
            catch (Exception er)
            {
                SphubCore.Reporting.Reporting.ER(er);
            }
        }

        private void DownloadModpack(string version, string patch)
        {
            //Patch
            try
            {
                Invoke((MethodInvoker)delegate
                {
                    GaddPage.GP.UpdateDownloadString("Now Downloading Modpack Version: " + version);
                });
                using (var client = new WebClient())
                {
                    client.DownloadProgressChanged += Wc_DownloadProgressChanged;
                    client.DownloadFileCompleted += PatchDlFinished;
                    l2.Dlnotif("Fetch:" + Classes.Definitions.UpdateURL + "packfiles/" + version + "/" + patch + "/pack.zip");
                    var url = new Uri(Classes.Definitions.UpdateURL + "packfiles/" + version + "/" + patch + "/pack.zip");
                    client.DownloadFileAsync(url, MCHandler.mclocation + "/" + "pack.szf");
                }
            }
            catch (Exception er)
            {
                SphubCore.Reporting.Reporting.ER(er);
            }
        }

        private static void PatchDlFinished(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                l2.Dlnotif("Extracting Patch");
                var zfs = ZipFile.OpenRead(MCHandler.mclocation + "/pack.szf");
                foreach (ZipArchiveEntry file in zfs.Entries)
                {
                    string completeFileName = Path.Combine(MCHandler.mclocation, file.FullName);
                    if (!file.ToString().EndsWith(@"/"))
                    {
                        l2.Dlnotif("File Updated:" + completeFileName);
                        file.ExtractToFile(completeFileName, true);
                    }
                }
                l2.StartGame();
            }
            catch (Exception er)
            {
                using (SphubCore.ErrorWindow ew = new SphubCore.ErrorWindow(er))
                {
                    ew.Show();
                }
            }
        }

        private static void PackDlFinished(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                l2.Dlnotif("Cleaning Up directories");
                if (Directory.Exists(MCHandler.mclocation + "/mods"))
                {
                    Directory.Delete(MCHandler.mclocation + "/mods", true);
                }
                if (Directory.Exists(MCHandler.mclocation + "/config"))
                {
                    Directory.Delete(MCHandler.mclocation + "/config", true);
                }
                if (Directory.Exists(MCHandler.mclocation + "/resources"))
                {
                    Directory.Delete(MCHandler.mclocation + "/resources", true);
                }
                l2.Dlnotif("Spawing Directories");
                Directory.CreateDirectory(MCHandler.mclocation + "/mods");
                Directory.CreateDirectory(MCHandler.mclocation + "/config");
                Directory.CreateDirectory(MCHandler.mclocation + "/resources");
                l2.Dlnotif("Extracting");
                var zfs = ZipFile.OpenRead(MCHandler.mclocation + "/pack.szf");
                zfs.ExtractToDirectory(MCHandler.mclocation);
                l2.StartGame();
            }
            catch (Exception er)
            {
                SphubCore.Reporting.Reporting.ER(er);
            }
        }

        public void Dlnotif(string msg)
        {
            Invoke((MethodInvoker)delegate
            {
                GaddPage.GP.UpdateDownloadString(msg);
            });
            Console.WriteLine(msg);
        }

        private static void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Console.WriteLine($"Downloaded: {e.BytesReceived} out of {e.TotalBytesToReceive}");
        }

        private void Downloader_ChangeFile(DownloadFileChangedEventArgs e)
        {
            Console.WriteLine(String.Format("Now Downloading : {0} - {1} ({2}/{3})", e.FileKind, e.FileName, e.CurrentValue, e.MaxValue));
            Invoke((MethodInvoker)delegate
            {
                GaddPage.GP.UpdateDownloadString("Now Downloading : " + e.FileKind + "/" + e.FileName + ", " + e.CurrentValue + e.MaxValue);
            });
        }

        #endregion Downloader

        #region Misc Classes

        private void Launch2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public static void Debug(int a)
        {
            if (a == 1)
            {
                Console.View(true);
            }
            else
            {
                Console.View(false);
            }
        }

        #endregion Misc Classes

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to switch to the debug branch of the launcher?.", "Debug Manager", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Classes.Definitions.SwitchBuildServer();
                label1.Text = "Build: " + System.IO.File.ReadAllText(@"version.txt") + ", Connected to " + Classes.Definitions.ServerName + " Build Server";
                //do something
            }
            if (dialogResult == DialogResult.No)
            {
                Classes.Definitions.SwitchBuildServer();
                label1.Text = "Build: " + System.IO.File.ReadAllText(@"version.txt") + ", Connected to " + Classes.Definitions.ServerName + " Build Server";
            }
        }
    }
}