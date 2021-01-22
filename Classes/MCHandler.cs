using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CmlLib.Launcher;
using System.Net;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO.Compression;
using System.Windows.Forms;
using SphubCore;

namespace GADD_Application
{
    public class MCHandler
    {
        public static string mclocation = Properties.Settings.Default.mclocation;
        public string javalocation = "";
        public string version_folder = mclocation + "/" + "versions/1.12.2-forge1.12.2-14.23.5.2847";
        public string version_file = mclocation + "/" + "versions/1.12.2-forge1.12.2-14.23.5.2847/1.12.2-forge1.12.2-14.23.5.2847.json";
        public string mod_location = mclocation + "/mods";
        public string mod_config = mclocation + "/config";

        public static MCHandler MCH;

        public static bool AuthenticateLogin(string username, string password)
        {
            var login = new MLogin();
            var result = login.Authenticate(username, password);
            if (result.Result == MLoginResult.Success)
            {
                Console.WriteLine("Login Success : " + result.Username);
                GADD_Application.Properties.Settings.Default.username = username;
                GADD_Application.Properties.Settings.Default.password = password;
                Properties.Settings.Default.Save();
                Launch2.l2.session = result;
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Login, Please Try Again");
                return false;
            }
        }

        public static void Play()
        {
            try
            {
                Launch2.l2.MC_Play();
            }
            catch (Exception errormessage)
            {
                ErrorWindow ew = new ErrorWindow(errormessage);
                ew.Show();
            }
        }
    }
}