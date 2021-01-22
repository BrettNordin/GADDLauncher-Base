//#define DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GADD_Application.Classes
{
    public static class Definitions
    {
#if DEBUG
        static public string UpdateURL = "http://sphubpublic.s3.amazonaws.com/testbuilds/";
        static public string ServerName = "TESTING";

#else
        static public string UpdateURL = "http://sphubpublic.s3.amazonaws.com/gaddlauncher/";
        static public string ServerName = "LIVE";
#endif
        static public string BuildCode = "Build 2020517d";

        static public void SwitchBuildServer()
        {
            if (ServerName == "LIVE")
            {
                UpdateURL = "http://sphubpublic.s3.amazonaws.com/testbuilds/";
                ServerName = "TESTING";
            }
            else
            {
                UpdateURL = "http://sphubpublic.s3.amazonaws.com/gaddlauncher/";
                ServerName = "LIVE";
            }
        }
    }
}