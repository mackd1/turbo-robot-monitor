namespace SIEM_Project
{
    partial class mainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateTrainingDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alertViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatTesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowsToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1080, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateTrainingDataToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // generateTrainingDataToolStripMenuItem
            // 
            this.generateTrainingDataToolStripMenuItem.Name = "generateTrainingDataToolStripMenuItem";
            this.generateTrainingDataToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.generateTrainingDataToolStripMenuItem.Text = "Generate Training Data";
            this.generateTrainingDataToolStripMenuItem.Click += new System.EventHandler(this.generateTrainingDataToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processViewerToolStripMenuItem,
            this.networkMonitorToolStripMenuItem,
            this.alertViewerToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // processViewerToolStripMenuItem
            // 
            this.processViewerToolStripMenuItem.Name = "processViewerToolStripMenuItem";
            this.processViewerToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.processViewerToolStripMenuItem.Text = "Process Monitor";
            this.processViewerToolStripMenuItem.Click += new System.EventHandler(this.processViewerToolStripMenuItem_Click);
            // 
            // networkMonitorToolStripMenuItem
            // 
            this.networkMonitorToolStripMenuItem.Name = "networkMonitorToolStripMenuItem";
            this.networkMonitorToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.networkMonitorToolStripMenuItem.Text = "Network Monitor";
            this.networkMonitorToolStripMenuItem.Click += new System.EventHandler(this.networkMonitorToolStripMenuItem_Click);
            // 
            // alertViewerToolStripMenuItem
            // 
            this.alertViewerToolStripMenuItem.Name = "alertViewerToolStripMenuItem";
            this.alertViewerToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.alertViewerToolStripMenuItem.Text = "Alert Log";
            this.alertViewerToolStripMenuItem.Click += new System.EventHandler(this.alertViewerToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 543);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1080, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatTesterToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // formatTesterToolStripMenuItem
            // 
            this.formatTesterToolStripMenuItem.Name = "formatTesterToolStripMenuItem";
            this.formatTesterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.formatTesterToolStripMenuItem.Text = "Format Tester";
            this.formatTesterToolStripMenuItem.Click += new System.EventHandler(this.formatTesterToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 565);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mainForm";
            this.Text = "SIEM ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem generateTrainingDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkMonitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alertViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatTesterToolStripMenuItem;
    }
}

