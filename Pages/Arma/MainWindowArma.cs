using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using SphubCore.Reporting;

namespace GADD_Application
{
    public partial class MainWindowArma : UserControl
    {
        public static MainWindowArma MWArma;
        private bool lockout = false;

        public MainWindowArma()
        {
            InitializeComponent();
            MWArma = this;
            lockout = true;
            try
            {
                //SteamClient.Init(107410);
            }
            catch (Exception e)
            {
                lockout = true;
                throw e;
            }
            Liviona_Menu_Button.Font = new Font("Orbitron", 12);
        }

        public void InitializeWindow()
        {
            Console.View(true);
            try
            {
                if (lockout)
                {
                    try
                    {
                        //SteamClient.Init(107410);
                        lockout = false;
                        //Username_Display.Text = SteamClient.Name;
                    }
                    catch (Exception e)
                    {
                        Launch2.l2.SwitchWindows(0);
                        //SphubCore.Reporting.Reporting.ER(e);
                        MessageBox.Show(e.Message, "Warning");
                    }
                }
                else
                {
                    //Username_Display.Text = SteamClient.Name;
                }
            }
            catch (Exception e)
            {
                Reporting.ER(e);
            }
        }

        private void Button_Display_GaddPack_Click(object sender, EventArgs e)
        {
            HideWindows();
        }

        private void HideWindows()
        {
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            Launch2.l2.SwitchWindows(0);
        }

        private void Button_Display_settings_Click(object sender, EventArgs e)
        {
            HideWindows();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        }

        private void Liviona_Menu_Button_Click(object sender, EventArgs e)
        {
        }

        private void Tanoa_Menu_Button_Click(object sender, EventArgs e)
        {
        }
    }
}