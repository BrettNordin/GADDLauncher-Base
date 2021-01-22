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
    public partial class Home : UserControl
    {
        public Home()
        {
            try
            {
                InitializeComponent();
                PlayArma.TabStop = false;
                PlayArma.FlatStyle = FlatStyle.Flat;
                PlayArma.FlatAppearance.BorderSize = 0;
                PlayArma.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
                PlayMinecraft.TabStop = false;
                PlayMinecraft.FlatStyle = FlatStyle.Flat;
                PlayMinecraft.FlatAppearance.BorderSize = 0;
                PlayMinecraft.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
                this.PlayMinecraft.FlatAppearance.MouseOverBackColor = this.PlayMinecraft.BackColor;
                this.PlayMinecraft.BackColorChanged += (s, e) =>
                {
                    this.PlayMinecraft.FlatAppearance.MouseOverBackColor = this.PlayMinecraft.BackColor;
                };
                this.PlayArma.FlatAppearance.MouseOverBackColor = this.PlayArma.BackColor;
                this.PlayArma.BackColorChanged += (s, e) =>
                {
                    this.PlayArma.FlatAppearance.MouseOverBackColor = this.PlayArma.BackColor;
                };
            }
            catch (Exception errormessage)
            {
                ErrorWindow ew = new ErrorWindow(errormessage);
                ew.Show();
            }
        }

        private void PlayArma_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.fav_men = 21;
            Properties.Settings.Default.Save();
            Launch2.l2.SwitchWindows(21);
        }

        private void PlayMinecraft_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.fav_men = 11;
            Properties.Settings.Default.Save();
            Launch2.l2.SwitchWindows(11);
        }
    }
}