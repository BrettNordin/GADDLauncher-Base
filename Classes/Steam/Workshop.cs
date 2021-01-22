using Steamworks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace GL.Steam
{
    public static class SteamWorkshop
    {
        private readonly static Dictionary<ulong, PublishedFileId_t> PublishedFileIdTs;

        private static bool _loaded;
        public static string steamuser;
        public static long? SteamId;

        static SteamWorkshop()
        {
            SteamWorkshop.PublishedFileIdTs = new Dictionary<ulong, PublishedFileId_t>();
        }

        public static void DownloadProgress(ulong mid, Action<ulong, ulong> onProgress = null, Action onComplete = null)
        {
            if (!SteamWorkshop._loaded)
            {
                throw new SteamWorkshopException("Unable to connect to Steam Client, is it open?");
            }
            if (SteamWorkshop.IsInstalled(mid))
            {
                Action action2 = onComplete;
                if (action2 == null)
                {
                    return;
                }
                action2();
                return;
            }
            PublishedFileId_t publishedFileId = SteamWorkshop.GetPublishedFileId(mid);
            Task.Factory.StartNew(() =>
            {
                ulong num;
                ulong num1;
                do
                {
                    SteamUGC.GetItemDownloadInfo(publishedFileId, out num, out num1);
                    Action<ulong, ulong> action = onProgress;
                    if (action != null)
                    {
                        action(num, num1);
                    }
                    else
                    {
                    }
                    Thread.Sleep(1000);
                }
                while (!SteamWorkshop.IsInstalled(mid) && SteamAPI.IsSteamRunning());
                if (!SteamAPI.IsSteamRunning())
                {
                    return;
                }
                if (SteamWorkshop.IsInstalled(mid))
                {
                    Action action1 = onComplete;
                    if (action1 == null)
                    {
                        return;
                    }
                    action1();
                }
            });
        }

        public static string GetModPath(ulong mid)
        {
            ulong num;
            string str;
            uint num1;
            if (!SteamWorkshop._loaded)
            {
                throw new SteamWorkshopException("Unable to connect to Steam Client, is it open?");
            }
            if (!SteamWorkshop.IsSubscribed(mid))
            {
                throw new SteamWorkshopException(string.Concat("Not subscribed to mod - ", mid.ToString()));
            }
            SteamUGC.GetItemInstallInfo(SteamWorkshop.GetPublishedFileId(mid), out num, out str, 1024, out num1);
            return str;
        }

        private static PublishedFileId_t GetPublishedFileId(ulong mid)
        {
            if (SteamWorkshop.PublishedFileIdTs.ContainsKey(mid))
            {
                return SteamWorkshop.PublishedFileIdTs[mid];
            }
            SteamWorkshop.PublishedFileIdTs[mid] = new PublishedFileId_t()
            {
                m_PublishedFileId = mid
            };
            return SteamWorkshop.PublishedFileIdTs[mid];
        }

        internal static bool Init()
        {
            if (!Packsize.Test())
            {
                return false;
            }
            if (!SteamAPI.Init())
            {
                return false;
            }
            SteamWorkshop.steamuser = SteamFriends.GetPersonaName();
            SteamWorkshop.SteamId = new long?(Convert.ToInt64(SteamUser.GetSteamID().m_SteamID));
            SteamWorkshop._loaded = true;
            AppDomain.CurrentDomain.ProcessExit += new EventHandler((object sender, EventArgs eventArgs) => SteamWorkshop.Shutdown());
            return true;
        }

        public static bool IsInstalled(ulong mid)
        {
            if (!SteamWorkshop._loaded)
            {
                throw new SteamWorkshopException("Unable to connect to Steam Client, is it open?");
            }
            return (SteamUGC.GetItemState(SteamWorkshop.GetPublishedFileId(mid)) & 4) == 4;
        }

        public static bool IsSubscribed(ulong mid)
        {
            if (!SteamWorkshop._loaded)
            {
                throw new SteamWorkshopException("Unable to connect to Steam Client, is it open?");
            }
            PublishedFileId_t[] publishedFileIdTArray = new PublishedFileId_t[SteamUGC.GetNumSubscribedItems()];
            SteamUGC.GetSubscribedItems(publishedFileIdTArray, SteamUGC.GetNumSubscribedItems());
            return (
                from i in (IEnumerable<PublishedFileId_t>)publishedFileIdTArray
                where i.m_PublishedFileId == mid
                select i).ToArray<PublishedFileId_t>().Length != 0;
        }

        internal static void Shutdown()
        {
            try
            {
                SteamAPI.Shutdown();
            }
            catch
            {
            }
        }

        public static void Subscribe(ulong mid)
        {
            if (!SteamWorkshop._loaded)
            {
                throw new SteamWorkshopException("Unable to connect to Steam Client, is it open?");
            }
            PublishedFileId_t publishedFileId = SteamWorkshop.GetPublishedFileId(mid);
            SteamUGC.SubscribeItem(publishedFileId);
            SteamUGC.DownloadItem(publishedFileId, true);
        }

        public static void Unsubscribe(ulong mid)
        {
            if (!SteamWorkshop._loaded)
            {
                throw new SteamWorkshopException("Unable to connect to Steam Client, is it open?");
            }
            SteamUGC.UnsubscribeItem(SteamWorkshop.GetPublishedFileId(mid));
        }

        public static void Verify(ulong mid)
        {
            if (!SteamWorkshop._loaded)
            {
                throw new SteamWorkshopException("Unable to connect to Steam Client, is it open?");
            }
            SteamUGC.DownloadItem(SteamWorkshop.GetPublishedFileId(mid), true);
        }
    }
}