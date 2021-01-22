namespace GADD_Application
{
    partial class LoginMC
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
            this.LoginWindow = new System.Windows.Forms.Panel();
            this.Login_Button = new System.Windows.Forms.Button();
            this.password_login = new System.Windows.Forms.TextBox();
            this.Username_Login = new System.Windows.Forms.TextBox();
            this.password_login_lable = new System.Windows.Forms.Label();
            this.Username_Login_Lable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginPicture = new System.Windows.Forms.PictureBox();
            this.a3Switcher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginWindow
            // 
            this.LoginWindow.BackColor = System.Drawing.Color.Transparent;
            this.LoginWindow.BackgroundImage = global::GADD_Application.Properties.Resources.Greybackground;
            this.LoginWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginWindow.Controls.Add(this.label1);
            this.LoginWindow.Controls.Add(this.Login_Button);
            this.LoginWindow.Controls.Add(this.password_login);
            this.LoginWindow.Controls.Add(this.Username_Login);
            this.LoginWindow.Controls.Add(this.password_login_lable);
            this.LoginWindow.Controls.Add(this.Username_Login_Lable);
            this.LoginWindow.Location = new System.Drawing.Point(209, 151);
            this.LoginWindow.Name = "LoginWindow";
            this.LoginWindow.Size = new System.Drawing.Size(472, 313);
            this.LoginWindow.TabIndex = 3;
            // 
            // Login_Button
            // 
            this.Login_Button.BackgroundImage = global::GADD_Application.Properties.Resources.login;
            this.Login_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login_Button.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Button.ForeColor = System.Drawing.Color.Cornsilk;
            this.Login_Button.Location = new System.Drawing.Point(61, 214);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(335, 41);
            this.Login_Button.TabIndex = 3;
            this.Login_Button.Text = "LOG IN";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // password_login
            // 
            this.password_login.BackColor = System.Drawing.SystemColors.InfoText;
            this.password_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_login.Font = new System.Drawing.Font("Rockwell", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_login.ForeColor = System.Drawing.Color.White;
            this.password_login.Location = new System.Drawing.Point(61, 138);
            this.password_login.Name = "password_login";
            this.password_login.PasswordChar = '•';
            this.password_login.Size = new System.Drawing.Size(335, 76);
            this.password_login.TabIndex = 2;
            // 
            // Username_Login
            // 
            this.Username_Login.BackColor = System.Drawing.SystemColors.InfoText;
            this.Username_Login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username_Login.Font = new System.Drawing.Font("Rockwell", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Login.ForeColor = System.Drawing.Color.White;
            this.Username_Login.Location = new System.Drawing.Point(61, 71);
            this.Username_Login.Name = "Username_Login";
            this.Username_Login.Size = new System.Drawing.Size(335, 76);
            this.Username_Login.TabIndex = 1;
            // 
            // password_login_lable
            // 
            this.password_login_lable.AutoSize = true;
            this.password_login_lable.Font = new System.Drawing.Font("PhantomBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_login_lable.ForeColor = System.Drawing.Color.White;
            this.password_login_lable.Location = new System.Drawing.Point(57, 114);
            this.password_login_lable.Name = "password_login_lable";
            this.password_login_lable.Size = new System.Drawing.Size(242, 40);
            this.password_login_lable.TabIndex = 1;
            this.password_login_lable.Text = "Password:";
            this.password_login_lable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Username_Login_Lable
            // 
            this.Username_Login_Lable.AutoSize = true;
            this.Username_Login_Lable.Font = new System.Drawing.Font("PhantomBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Login_Lable.ForeColor = System.Drawing.Color.White;
            this.Username_Login_Lable.Location = new System.Drawing.Point(57, 47);
            this.Username_Login_Lable.Name = "Username_Login_Lable";
            this.Username_Login_Lable.Size = new System.Drawing.Size(124, 40);
            this.Username_Login_Lable.TabIndex = 0;
            this.Username_Login_Lable.Text = "Email:";
            this.Username_Login_Lable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-29, 529);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(996, 52);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LoginPicture
            // 
            this.LoginPicture.BackColor = System.Drawing.Color.Transparent;
            this.LoginPicture.BackgroundImage = global::GADD_Application.Properties.Resources.GADDMC_MAIN_SHADOW;
            this.LoginPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LoginPicture.Location = new System.Drawing.Point(323, 36);
            this.LoginPicture.Name = "LoginPicture";
            this.LoginPicture.Size = new System.Drawing.Size(250, 115);
            this.LoginPicture.TabIndex = 4;
            this.LoginPicture.TabStop = false;
            // 
            // a3Switcher
            // 
            this.a3Switcher.BackgroundImage = global::GADD_Application.Properties.Resources._231;
            this.a3Switcher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.a3Switcher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a3Switcher.ForeColor = System.Drawing.Color.Transparent;
            this.a3Switcher.Location = new System.Drawing.Point(0, 466);
            this.a3Switcher.Name = "a3Switcher";
            this.a3Switcher.Size = new System.Drawing.Size(83, 44);
            this.a3Switcher.TabIndex = 6;
            this.a3Switcher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.a3Switcher.UseVisualStyleBackColor = true;
            this.a3Switcher.Visible = false;
            this.a3Switcher.Click += new System.EventHandler(this.A3Switcher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(65, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "*Sign-in using your Mojang account!";
            // 
            // LoginMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::GADD_Application.Properties.Resources.Minecraft_Path_Tracing_Feature;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.a3Switcher);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginWindow);
            this.Controls.Add(this.LoginPicture);
            this.Name = "LoginMC";
            this.Size = new System.Drawing.Size(918, 510);
            this.LoginWindow.ResumeLayout(false);
            this.LoginWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginWindow;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.TextBox password_login;
        private System.Windows.Forms.TextBox Username_Login;
        private System.Windows.Forms.Label password_login_lable;
        private System.Windows.Forms.Label Username_Login_Lable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox LoginPicture;
        private System.Windows.Forms.Button a3Switcher;
        private System.Windows.Forms.Label label1;
    }
}
