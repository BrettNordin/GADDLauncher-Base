namespace GADD_Application
{
    partial class MainWindowMC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Username_Display = new System.Windows.Forms.Label();
            this.Button_Display_GaddPack = new System.Windows.Forms.Button();
            this.LoginPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Display_settings = new System.Windows.Forms.Button();
            this.Logout_Button = new System.Windows.Forms.Button();
            this.MCSettings = new GADD_Application.MCSettings();
            this.PackWindow_Gadd = new GADD_Application.GaddPage();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Username_Display
            // 
            this.Username_Display.AutoSize = true;
            this.Username_Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Username_Display.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Display.ForeColor = System.Drawing.Color.White;
            this.Username_Display.Location = new System.Drawing.Point(11, 46);
            this.Username_Display.Name = "Username_Display";
            this.Username_Display.Size = new System.Drawing.Size(205, 53);
            this.Username_Display.TabIndex = 10;
            this.Username_Display.Text = "$USERNAME";
            // 
            // Button_Display_GaddPack
            // 
            this.Button_Display_GaddPack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Button_Display_GaddPack.BackgroundImage = global::GADD_Application.Properties.Resources.login;
            this.Button_Display_GaddPack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Display_GaddPack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Display_GaddPack.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold);
            this.Button_Display_GaddPack.ForeColor = System.Drawing.Color.White;
            this.Button_Display_GaddPack.Location = new System.Drawing.Point(18, 88);
            this.Button_Display_GaddPack.Name = "Button_Display_GaddPack";
            this.Button_Display_GaddPack.Size = new System.Drawing.Size(143, 43);
            this.Button_Display_GaddPack.TabIndex = 12;
            this.Button_Display_GaddPack.Text = "GADD PACK";
            this.Button_Display_GaddPack.UseVisualStyleBackColor = false;
            this.Button_Display_GaddPack.Click += new System.EventHandler(this.Button_Display_GaddPack_Click);
            // 
            // LoginPicture
            // 
            this.LoginPicture.BackColor = System.Drawing.Color.Transparent;
            this.LoginPicture.BackgroundImage = global::GADD_Application.Properties.Resources.GADDMC_MAIN_SHADOW;
            this.LoginPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LoginPicture.Location = new System.Drawing.Point(8, 429);
            this.LoginPicture.Name = "LoginPicture";
            this.LoginPicture.Size = new System.Drawing.Size(163, 74);
            this.LoginPicture.TabIndex = 8;
            this.LoginPicture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::GADD_Application.Properties.Resources.Greybackground;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 415);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "Welcome:";
            // 
            // Button_Display_settings
            // 
            this.Button_Display_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.Button_Display_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Display_settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Display_settings.Font = new System.Drawing.Font("Orbitron", 7.75F, System.Drawing.FontStyle.Bold);
            this.Button_Display_settings.ForeColor = System.Drawing.Color.White;
            this.Button_Display_settings.Image = global::GADD_Application.Properties.Resources.Greybackground1;
            this.Button_Display_settings.Location = new System.Drawing.Point(18, 343);
            this.Button_Display_settings.Name = "Button_Display_settings";
            this.Button_Display_settings.Size = new System.Drawing.Size(143, 30);
            this.Button_Display_settings.TabIndex = 22;
            this.Button_Display_settings.Text = "Settings";
            this.Button_Display_settings.UseVisualStyleBackColor = false;
            this.Button_Display_settings.Click += new System.EventHandler(this.Button_Display_settings_Click_1);
            // 
            // Logout_Button
            // 
            this.Logout_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Logout_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logout_Button.Font = new System.Drawing.Font("Orbitron", 7.75F, System.Drawing.FontStyle.Bold);
            this.Logout_Button.ForeColor = System.Drawing.Color.Transparent;
            this.Logout_Button.Image = global::GADD_Application.Properties.Resources.Greybackground1;
            this.Logout_Button.Location = new System.Drawing.Point(18, 375);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Size = new System.Drawing.Size(143, 30);
            this.Logout_Button.TabIndex = 21;
            this.Logout_Button.Text = "Change Game";
            this.Logout_Button.UseVisualStyleBackColor = false;
            this.Logout_Button.Visible = false;
            this.Logout_Button.Click += new System.EventHandler(this.Logout_Button_Click_1);
            // 
            // MCSettings
            // 
            this.MCSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MCSettings.BackColor = System.Drawing.Color.Transparent;
            this.MCSettings.BackgroundImage = global::GADD_Application.Properties.Resources.Greybackground;
            this.MCSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MCSettings.Location = new System.Drawing.Point(242, 8);
            this.MCSettings.Margin = new System.Windows.Forms.Padding(4);
            this.MCSettings.Name = "MCSettings";
            this.MCSettings.Size = new System.Drawing.Size(676, 423);
            this.MCSettings.TabIndex = 16;
            this.MCSettings.Visible = false;
            // 
            // PackWindow_Gadd
            // 
            this.PackWindow_Gadd.BackColor = System.Drawing.Color.Transparent;
            this.PackWindow_Gadd.BackgroundImage = global::GADD_Application.Properties.Resources.Greybackground;
            this.PackWindow_Gadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PackWindow_Gadd.Location = new System.Drawing.Point(242, 8);
            this.PackWindow_Gadd.Margin = new System.Windows.Forms.Padding(4);
            this.PackWindow_Gadd.Name = "PackWindow_Gadd";
            this.PackWindow_Gadd.Size = new System.Drawing.Size(672, 423);
            this.PackWindow_Gadd.TabIndex = 14;
            this.PackWindow_Gadd.Visible = false;
            // 
            // MainWindowMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::GADD_Application.Properties.Resources.Minecraft_Path_Tracing_Feature;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Button_Display_settings);
            this.Controls.Add(this.Logout_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Display_GaddPack);
            this.Controls.Add(this.Username_Display);
            this.Controls.Add(this.LoginPicture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MCSettings);
            this.Controls.Add(this.PackWindow_Gadd);
            this.Name = "MainWindowMC";
            this.Size = new System.Drawing.Size(918, 510);
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GaddPage PackWindow_Gadd;
        private System.Windows.Forms.Button Button_Display_GaddPack;
        private System.Windows.Forms.Label Username_Display;
        private System.Windows.Forms.PictureBox LoginPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private MCSettings MCSettings;
        private System.Windows.Forms.Button Button_Display_settings;
        private System.Windows.Forms.Button Logout_Button;
    }
}
