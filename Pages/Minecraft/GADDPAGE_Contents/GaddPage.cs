using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADD_Application
{
    public partial class GaddPage : UserControl
    {
        public static GaddPage GP;

        private int activebut = 0;

        public GaddPage()
        {
            InitializeComponent();
            Header_Button_Play.Font = new Font("Orbitron", 13, FontStyle.Bold);
            GP = this;
        }

        public void UpdateDownloadString(string text)
        {
            UpdateText.Text = text;
        }

        private void Header_Button_Play_MouseEnter(object sender, EventArgs e)
        {
            if (activebut == 1)
            {
                Header_Button_Play.Font = new Font("Orbitron", 13);
            }
        }

        private void Header_Button_Play_MouseLeave(object sender, EventArgs e)
        {
            if (activebut == 1)
            {
                Header_Button_Play.Font = new Font("Orbitron", 12);
            }
        }

        private void Header_Button_Play_Click(object sender, EventArgs e)
        {
            Header_Button_Play.Font = new Font("Orbitron", 13, FontStyle.Bold);
            ChangelogButton.Font = new Font("Orbitron", 12);
            activebut = 0;
            pictureBox1.Visible = true;
            MCGPPlay.Visible = true;
            webBrowser1.Visible = false;
        }

        public void ButtonStat(bool st)
        {
            MCGPPlay.Enabled = st;
        }

        private void MCGPPlay_Click(object sender, EventArgs e)
        {
            MCHandler.Play();
        }

        private void ChangelogButton_Click(object sender, EventArgs e)
        {
            ChangelogButton.Font = new Font("Orbitron", 13, FontStyle.Bold);
            Header_Button_Play.Font = new Font("Orbitron", 12);
            activebut = 1;
            pictureBox1.Visible = false;
            MCGPPlay.Visible = false;
            webBrowser1.Visible = true;
        }

        private void ChangelogButton_MouseEnter(object sender, EventArgs e)
        {
            if (activebut == 0)
            {
                ChangelogButton.Font = new Font("Orbitron", 13);
            }
        }

        private void ChangelogButton_Leave(object sender, EventArgs e)
        {
            if (activebut == 0)
            {
                ChangelogButton.Font = new Font("Orbitron", 12);
            }
        }
    }
}