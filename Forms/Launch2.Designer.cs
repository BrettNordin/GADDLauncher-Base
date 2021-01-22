namespace GADD_Application
{
    partial class Launch2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launch2));
            this.label1 = new System.Windows.Forms.Label();
            this.HomeWindow = new GADD_Application.Home();
            this.MCMainWindow = new GADD_Application.MainWindowMC();
            this.LoginWindow = new GADD_Application.LoginMC();
            this.mainWindowArma = new GADD_Application.MainWindowArma();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 594);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Version: 1.1.1.1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // HomeWindow
            // 
            this.HomeWindow.BackColor = System.Drawing.Color.Transparent;
            this.HomeWindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeWindow.BackgroundImage")));
            this.HomeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeWindow.Location = new System.Drawing.Point(20, 36);
            this.HomeWindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HomeWindow.Name = "HomeWindow";
            this.HomeWindow.Size = new System.Drawing.Size(895, 555);
            this.HomeWindow.TabIndex = 2;
            this.HomeWindow.Visible = false;
            // 
            // MCMainWindow
            // 
            this.MCMainWindow.BackColor = System.Drawing.Color.Transparent;
            this.MCMainWindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MCMainWindow.BackgroundImage")));
            this.MCMainWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MCMainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MCMainWindow.Location = new System.Drawing.Point(20, 36);
            this.MCMainWindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MCMainWindow.Name = "MCMainWindow";
            this.MCMainWindow.Size = new System.Drawing.Size(895, 555);
            this.MCMainWindow.TabIndex = 1;
            this.MCMainWindow.Visible = false;
            // 
            // LoginWindow
            // 
            this.LoginWindow.BackColor = System.Drawing.Color.Transparent;
            this.LoginWindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginWindow.BackgroundImage")));
            this.LoginWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginWindow.Location = new System.Drawing.Point(20, 36);
            this.LoginWindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginWindow.Name = "LoginWindow";
            this.LoginWindow.Size = new System.Drawing.Size(895, 555);
            this.LoginWindow.TabIndex = 0;
            // 
            // mainWindowArma
            // 
            this.mainWindowArma.BackColor = System.Drawing.Color.Transparent;
            this.mainWindowArma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainWindowArma.BackgroundImage")));
            this.mainWindowArma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainWindowArma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainWindowArma.Location = new System.Drawing.Point(20, 36);
            this.mainWindowArma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainWindowArma.Name = "mainWindowArma";
            this.mainWindowArma.Size = new System.Drawing.Size(895, 555);
            this.mainWindowArma.TabIndex = 4;
            this.mainWindowArma.Visible = false;
            // 
            // Launch2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(935, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HomeWindow);
            this.Controls.Add(this.MCMainWindow);
            this.Controls.Add(this.LoginWindow);
            this.Controls.Add(this.mainWindowArma);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Launch2";
            this.Padding = new System.Windows.Forms.Padding(20, 36, 20, 20);
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "GADD Launcher";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Launch2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LoginMC LoginWindow;
        private MainWindowMC MCMainWindow;
        private Home HomeWindow;
        private System.Windows.Forms.Label label1;
        private MainWindowArma mainWindowArma;
    }
}