namespace GADD_Application
{
    partial class Home
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlayArma = new System.Windows.Forms.Button();
            this.PlayMinecraft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-29, 529);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(996, 52);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // PlayArma
            // 
            this.PlayArma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayArma.Location = new System.Drawing.Point(0, 0);
            this.PlayArma.Name = "PlayArma";
            this.PlayArma.Size = new System.Drawing.Size(460, 511);
            this.PlayArma.TabIndex = 8;
            this.PlayArma.UseVisualStyleBackColor = true;
            this.PlayArma.Click += new System.EventHandler(this.PlayArma_Click);
            // 
            // PlayMinecraft
            // 
            this.PlayMinecraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayMinecraft.Location = new System.Drawing.Point(455, 0);
            this.PlayMinecraft.Name = "PlayMinecraft";
            this.PlayMinecraft.Size = new System.Drawing.Size(460, 511);
            this.PlayMinecraft.TabIndex = 9;
            this.PlayMinecraft.UseVisualStyleBackColor = true;
            this.PlayMinecraft.Click += new System.EventHandler(this.PlayMinecraft_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::GADD_Application.Properties.Resources.split_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PlayArma);
            this.Controls.Add(this.PlayMinecraft);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(918, 510);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PlayArma;
        private System.Windows.Forms.Button PlayMinecraft;
    }
}
