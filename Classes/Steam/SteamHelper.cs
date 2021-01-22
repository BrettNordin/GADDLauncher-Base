/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using Steamworks;
using Steamworks.Data;

//using GL.Steam;
using GADD_Application.Pages.Arma.Subpages;

namespace GADD_Application.Classes.Steam
{
    public class Workshop
    {
        public static string WorkshopLocation;
        public readonly static string[] Tanoamodsrequired = { "497660133", "541888371", "639837898" };
        public readonly static string[] Livionamodsrequired = { "497660133", "541888371", "639837898" };
        public static string[] LivionModsInstalled;
        public static string[] LivionModsMissing;

        public static string GetInstalledTanoaMods()
        {
            string privatemodsinstalled = "";
            foreach (string mod in Tanoamodsrequired)
            {
                ulong num = Convert.ToUInt64(mod);
                if (ModInstallCheck(num))
                {
                    privatemodsinstalled = privatemodsinstalled + ',' + mod;
                }
            }
            return privatemodsinstalled.Substring(1);
        }

        public static void GetInstalledModsLiviona()
        {
            string[] privatemodsinstalled = { };
            foreach (string mod in Livionamodsrequired)
            {
                ulong num = Convert.ToUInt64(mod);
                if (ModInstallCheck(num))
                {
                    privatemodsinstalled.Append(mod);
                }
            }
            LivionModsInstalled = privatemodsinstalled;
            return;
        }

        public static bool ModInstallCheck(ulong mid)
        {
            var f = QuerySpecificFile(mid);
            //f.RunSynchronously();
            //f.Wait();
            var r = f.Result;

            if (!r.Value.IsSubscribed) return false;

            if (!r.Value.IsInstalled) return false;
            return true;
        }

        public static string ModName(ulong mid)
        {
            var f = QuerySpecificFile(mid);
            //f.Wait();
            var r = f.Result;
            return r.Value.Title;
        }

        public static float DownloadPer(ulong mid)
        {
            var f = QuerySpecificFile(mid);
            var r = f.Result;
            return r.Value.DownloadAmount;
        }

        public static async Task<Steamworks.Ugc.Item?> QuerySpecificFile(ulong mid)
        {
            var item = await Steamworks.Ugc.Item.GetAsync(mid);
            Console.WriteLine(item.Value.IsInstalled.ToString());
            // var item = await SteamUGC.QueryFileAsync(497660133);
            return item;
        }

        public static Uri WebsiteURI(string UID)
        {
            return new Uri(string.Concat("http://steamcommunity.com/sharedfiles/filedetails/?id=", UID));
        }

        public static void SHUTDOWN()
        {
            SteamClient.Shutdown();
        }
    }
}*/