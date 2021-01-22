using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace GADD_Application
{
    public class FontSystem
    {
        public static PrivateFontCollection pfc = new PrivateFontCollection();

        public static FontSystem FS;

        public static void Init()
        {
            int fontLength = Properties.Resources.Orbitron_Regular.Length;
            byte[] fontdata = Properties.Resources.Orbitron_Regular;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);

            int fontLengthb = Properties.Resources.Orbitron_Medium.Length;
            byte[] fontdatab = Properties.Resources.Orbitron_Medium;
            System.IntPtr datab = Marshal.AllocCoTaskMem(fontLengthb);
            Marshal.Copy(fontdatab, 0, datab, fontLengthb);
            pfc.AddMemoryFont(datab, fontLengthb);

            int fontLengthc = Properties.Resources.ZillaSlabHighlight_Regular.Length;
            byte[] fontdatac = Properties.Resources.ZillaSlabHighlight_Regular;
            System.IntPtr datac = Marshal.AllocCoTaskMem(fontLengthc);
            Marshal.Copy(fontdatac, 0, datac, fontLengthc);
            pfc.AddMemoryFont(datac, fontLengthc);

            int fontLengthd = Properties.Resources.Orbitron_Black.Length;
            byte[] fontdatad = Properties.Resources.Orbitron_Black;
            System.IntPtr datad = Marshal.AllocCoTaskMem(fontLengthd);
            Marshal.Copy(fontdatad, 0, datad, fontLengthd);
            pfc.AddMemoryFont(datad, fontLengthd);
        }
    }
}