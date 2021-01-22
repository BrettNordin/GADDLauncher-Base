using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADD_Application.Classes
{
    public static class Toolkit
    {
        #region Version System

        private static string Pubversion = "";
        private static string PatchFile = "";
        private static string fullversion = "";

        public static int VersionParser(string[] x, string y, string z)
        {
            fullversion = z;
            if (y == "")
            {
                return 1;
            }
            //Determin if the version has a patch
            if (x.Length > 1)
            {
                //Patch
                string pubver = x[0];
                string patchv = x[1];
                Pubversion = pubver;
                PatchFile = patchv;
                //Check to see if client even has a patch version
                string[] localdata = y.Split('-');
                if (localdata.Length > 1)
                {
                    //Has a patch version
                    string localv = localdata[0];
                    string localpv = localdata[1];
                    if (localv == pubver)
                    {
                        if (localpv == patchv)
                        {
                            return 0; //Up to Date
                        }
                        else
                        {
                            return 3; //Needs to fetch patch file
                        }
                    }
                    else
                    {
                        return 2;
                    }
                }
                else
                {
                    //No patch Version, Check to see if Primary is correct
                    string localv = localdata[0];
                    if (localv == pubver)
                    {
                        return 3; //Fetch Patch
                    }
                    else
                    {
                        return 2; //Fetch Full
                    }
                }
            }
            else
            {
                //no patch
                string pubver = x[0];
                Pubversion = pubver;
                if (pubver == y)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        public static string PublicVersion()
        {
            return Pubversion;
        }

        public static string FullPublicVersion()
        {
            return fullversion;
        }

        public static string PublicPatchVersion()
        {
            return PatchFile;
        }

        #endregion Version System
    }
}