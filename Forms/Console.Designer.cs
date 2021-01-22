namespace GADD_Application
{
    partial class Console
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Console));
            this.RTB = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Export = new System.Windows.Forms.ToolStripButton();
            this.KillEngine = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RTB
            // 
            this.RTB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RTB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RTB.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RTB.Location = new System.Drawing.Point(0, 28);
            this.RTB.Name = "RTB";
            this.RTB.ReadOnly = true;
            this.RTB.Size = new System.Drawing.Size(725, 265);
            this.RTB.TabIndex = 0;
            this.RTB.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.Export,
            this.KillEngine});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(725, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(46, 24);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.exitToolStripMenuItem.Text = "Hide";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // Export
            // 
            this.Export.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Export.Image = ((System.Drawing.Image)(resources.GetObject("Export.Image")));
            this.Export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(56, 24);
            this.Export.Text = "Export";
            this.Export.Visible = false;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // KillEngine
            // 
            this.KillEngine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.KillEngine.Enabled = false;
            this.KillEngine.Image = ((System.Drawing.Image)(resources.GetObject("KillEngine.Image")));
            this.KillEngine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.KillEngine.Name = "KillEngine";
            this.KillEngine.Size = new System.Drawing.Size(132, 24);
            this.KillEngine.Text = "Force Close Game";
            this.KillEngine.Click += new System.EventHandler(this.KillEngine_Click);
            // 
            // Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 10F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 293);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.RTB);
            this.Font = new System.Drawing.Font("ZWAdobeF", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Console";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GADD Launcher DEBUG";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripButton Export;
        private System.Windows.Forms.ToolStripButton KillEngine;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}