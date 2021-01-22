namespace GADD_Application
{
    partial class GaddPage
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
            this.Header_Button_Play = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MCGPPlay = new System.Windows.Forms.Button();
            this.UpdateText = new System.Windows.Forms.Label();
            this.ChangelogButton = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Header_Button_Play
            // 
            this.Header_Button_Play.AutoSize = true;
            this.Header_Button_Play.Font = new System.Drawing.Font("Orbitron", 12F);
            this.Header_Button_Play.ForeColor = System.Drawing.Color.White;
            this.Header_Button_Play.Location = new System.Drawing.Point(163, 110);
            this.Header_Button_Play.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Header_Button_Play.Name = "Header_Button_Play";
            this.Header_Button_Play.Size = new System.Drawing.Size(121, 50);
            this.Header_Button_Play.TabIndex = 0;
            this.Header_Button_Play.Text = "Play";
            this.Header_Button_Play.Click += new System.EventHandler(this.Header_Button_Play_Click);
            this.Header_Button_Play.MouseEnter += new System.EventHandler(this.Header_Button_Play_MouseEnter);
            this.Header_Button_Play.MouseLeave += new System.EventHandler(this.Header_Button_Play_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orbitron", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "GADD Modpack";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GADD_Application.Properties.Resources.Minecraft_con_SEUS1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(8, 165);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1795, 737);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MCGPPlay
            // 
            this.MCGPPlay.BackgroundImage = global::GADD_Application.Properties.Resources.login;
            this.MCGPPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MCGPPlay.Cursor = System.Windows.Forms.Cursors.Default;
            this.MCGPPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MCGPPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCGPPlay.ForeColor = System.Drawing.Color.White;
            this.MCGPPlay.Location = new System.Drawing.Point(488, 866);
            this.MCGPPlay.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MCGPPlay.Name = "MCGPPlay";
            this.MCGPPlay.Size = new System.Drawing.Size(819, 98);
            this.MCGPPlay.TabIndex = 4;
            this.MCGPPlay.Text = "PLAY";
            this.MCGPPlay.UseVisualStyleBackColor = true;
            this.MCGPPlay.Click += new System.EventHandler(this.MCGPPlay_Click);
            // 
            // UpdateText
            // 
            this.UpdateText.AutoSize = true;
            this.UpdateText.ForeColor = System.Drawing.Color.White;
            this.UpdateText.Location = new System.Drawing.Point(307, 165);
            this.UpdateText.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.UpdateText.Name = "UpdateText";
            this.UpdateText.Size = new System.Drawing.Size(0, 32);
            this.UpdateText.TabIndex = 5;
            // 
            // ChangelogButton
            // 
            this.ChangelogButton.AutoSize = true;
            this.ChangelogButton.Font = new System.Drawing.Font("Orbitron", 12F);
            this.ChangelogButton.ForeColor = System.Drawing.Color.White;
            this.ChangelogButton.Location = new System.Drawing.Point(317, 110);
            this.ChangelogButton.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ChangelogButton.Name = "ChangelogButton";
            this.ChangelogButton.Size = new System.Drawing.Size(257, 50);
            this.ChangelogButton.TabIndex = 6;
            this.ChangelogButton.Text = "Changelog";
            this.ChangelogButton.Click += new System.EventHandler(this.ChangelogButton_Click);
            this.ChangelogButton.Leave += new System.EventHandler(this.ChangelogButton_Leave);
            this.ChangelogButton.MouseEnter += new System.EventHandler(this.ChangelogButton_MouseEnter);
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowNavigation = false;
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(8, 165);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(53, 48);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1835, 768);
            this.webBrowser1.TabIndex = 7;
            this.webBrowser1.Url = new System.Uri("http://gaddmc.com/changelog.html", System.UriKind.Absolute);
            this.webBrowser1.Visible = false;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 8;
            // 
            // GaddPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::GADD_Application.Properties.Resources.Greybackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChangelogButton);
            this.Controls.Add(this.UpdateText);
            this.Controls.Add(this.MCGPPlay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Header_Button_Play);
            this.Controls.Add(this.webBrowser1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "GaddPage";
            this.Size = new System.Drawing.Size(1803, 1023);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header_Button_Play;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button MCGPPlay;
        private System.Windows.Forms.Label UpdateText;
        private System.Windows.Forms.Label ChangelogButton;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label2;
    }
}
