namespace SIEM_Project
{
    partial class NetworkMonitor_Advanced
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
            this.SplitContainer_NetInfo = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer_NetInfo)).BeginInit();
            this.SplitContainer_NetInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer_NetInfo
            // 
            this.SplitContainer_NetInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer_NetInfo.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer_NetInfo.Name = "SplitContainer_NetInfo";
            this.SplitContainer_NetInfo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.SplitContainer_NetInfo.Size = new System.Drawing.Size(674, 441);
            this.SplitContainer_NetInfo.SplitterDistance = 89;
            this.SplitContainer_NetInfo.TabIndex = 0;
            // 
            // NetworkMonitor_Advanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 441);
            this.Controls.Add(this.SplitContainer_NetInfo);
            this.Name = "NetworkMonitor_Advanced";
            this.Text = "Network Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer_NetInfo)).EndInit();
            this.SplitContainer_NetInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitContainer_NetInfo;
    }
}