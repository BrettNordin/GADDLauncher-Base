using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SphubCore;

namespace GADD_Application
{
    public partial class LoginMC : UserControl
    {
        public LoginMC()
        {
            try
            {
                InitializeComponent();
                Username_Login.Text = GADD_Application.Properties.Settings.Default.username;
                password_login.Text = GADD_Application.Properties.Settings.Default.password;
                a3Switcher.TabStop = false;
                a3Switcher.FlatStyle = FlatStyle.Flat;
                a3Switcher.FlatAppearance.BorderSize = 0;
                a3Switcher.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
            }
            catch (Exception errormessage)
            {
                ErrorWindow ew = new ErrorWindow(errormessage);
                ew.Show();
            }
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Login_Button.Enabled = false;
                if (MCHandler.AuthenticateLogin(Username_Login.Text, password_login.Text))
                {
                    Launch2.l2.SwitchWindows(12);
                }
                Login_Button.Enabled = true;
            }
            catch (Exception errormessage)
            {
                ErrorWindow ew = new ErrorWindow(errormessage);
                ew.Show();
            }
        }

        private void A3Switcher_Click(object sender, EventArgs e)
        {
            Launch2.l2.SwitchWindows(0);
        }
    }
}