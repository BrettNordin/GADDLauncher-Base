namespace GADD_Application
{
    partial class MainWindowArma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowArma));
            this.Username_Display = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tanoa_Menu_Button = new MetroFramework.Controls.MetroButton();
            this.Liviona_Menu_Button = new MetroFramework.Controls.MetroButton();
            this.Button_Display_settings = new System.Windows.Forms.Button();
            this.Logout_Button = new System.Windows.Forms.Button();
            this.LoginPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Username_Display
            // 
            this.Username_Display.AutoSize = true;
            this.Username_Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Username_Display.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold);
            this.Username_Display.ForeColor = System.Drawing.Color.White;
            this.Username_Display.Location = new System.Drawing.Point(11, 46);
            this.Username_Display.Name = "Username_Display";
            this.Username_Display.Size = new System.Drawing.Size(149, 39);
            this.Username_Display.TabIndex = 10;
            this.Username_Display.Text = "$USERNAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Welcome:";
            // 
            // Tanoa_Menu_Button
            // 
            this.Tanoa_Menu_Button.Location = new System.Drawing.Point(18, 81);
            this.Tanoa_Menu_Button.Name = "Tanoa_Menu_Button";
            this.Tanoa_Menu_Button.Size = new System.Drawing.Size(143, 33);
            this.Tanoa_Menu_Button.TabIndex = 20;
            this.Tanoa_Menu_Button.Text = "Tanoa";
            this.Tanoa_Menu_Button.Click += new System.EventHandler(this.Tanoa_Menu_Button_Click);
            // 
            // Liviona_Menu_Button
            // 
            this.Liviona_Menu_Button.Location = new System.Drawing.Point(18, 120);
            this.Liviona_Menu_Button.Name = "Liviona_Menu_Button";
            this.Liviona_Menu_Button.Size = new System.Drawing.Size(143, 33);
            this.Liviona_Menu_Button.TabIndex = 21;
            this.Liviona_Menu_Button.Text = "Liviona";
            this.Liviona_Menu_Button.Click += new System.EventHandler(this.Liviona_Menu_Button_Click);
            // 
            // Button_Display_settings
            // 
            this.Button_Display_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.Button_Display_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Display_settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Display_settings.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Display_settings.ForeColor = System.Drawing.Color.White;
            this.Button_Display_settings.Image = global::GADD_Application.Properties.Resources.Greybackground1;
            this.Button_Display_settings.Location = new System.Drawing.Point(18, 349);
            this.Button_Display_settings.Name = "Button_Display_settings";
            this.Button_Display_settings.Size = new System.Drawing.Size(143, 30);
            this.Button_Display_settings.TabIndex = 13;
            this.Button_Display_settings.Text = "Settings";
            this.Button_Display_settings.UseVisualStyleBackColor = false;
            this.Button_Display_settings.Click += new System.EventHandler(this.Button_Display_settings_Click);
            // 
            // Logout_Button
            // 
            this.Logout_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Logout_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logout_Button.Font = new System.Drawing.Font("Orbitron", 7.75F, System.Drawing.FontStyle.Bold);
            this.Logout_Button.ForeColor = System.Drawing.Color.Transparent;
            this.Logout_Button.Image = global::GADD_Application.Properties.Resources.Greybackground1;
            this.Logout_Button.Location = new System.Drawing.Point(18, 381);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Size = new System.Drawing.Size(143, 30);
            this.Logout_Button.TabIndex = 11;
            this.Logout_Button.Text = "Change Game";
            this.Logout_Button.UseVisualStyleBackColor = false;
            this.Logout_Button.Click += new System.EventHandler(this.Logout_Button_Click);
            // 
            // LoginPicture
            // 
            this.LoginPicture.BackColor = System.Drawing.Color.Transparent;
            this.LoginPicture.BackgroundImage = global::GADD_Application.Properties.Resources.EsportGADD;
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
            // MainWindowArma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::GADD_Application.Properties.Resources.Liv1_Phil;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Liviona_Menu_Button);
            this.Controls.Add(this.Tanoa_Menu_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Display_settings);
            this.Controls.Add(this.Username_Display);
            this.Controls.Add(this.Logout_Button);
            this.Controls.Add(this.LoginPicture);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainWindowArma";
            this.Size = new System.Drawing.Size(918, 510);
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button_Display_settings;
        private System.Windows.Forms.Label Username_Display;
        private System.Windows.Forms.PictureBox LoginPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Logout_Button;
        private MetroFramework.Controls.MetroButton Tanoa_Menu_Button;
        private MetroFramework.Controls.MetroButton Liviona_Menu_Button;
    }
}
