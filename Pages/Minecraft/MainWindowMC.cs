using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using GADD_Application.Forms;

namespace GADD_Application
{
    public partial class MainWindowMC : UserControl
    {
        public static MainWindowMC MWMC;

        public MainWindowMC()
        {
            InitializeComponent();
            MWMC = this;
        }

        public void InitializeWindow()
        {
            Username_Display.Text = Launch2.l2.session.Username;
        }

        private void Button_Display_GaddPack_Click(object sender, EventArgs e)
        {
            HideWindows();
            PackWindow_Gadd.Visible = true;
        }

        private void HideWindows()
        {
            PackWindow_Gadd.Visible = false;
            MCSettings.Visible = false;
        }

        private void Button_Display_settings_Click_1(object sender, EventArgs e)
        {
            HideWindows();
            MCSettings.Visible = true;
        }

        private void Logout_Button_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.fav_men = 0;
            Properties.Settings.Default.Save();
            HideWindows();
            Launch2.l2.SwitchWindows(0);
        }
    }
}