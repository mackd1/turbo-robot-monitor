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
            this.components = new System.ComponentModel.Container();
            this.netmonSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tcpGridView = new System.Windows.Forms.DataGridView();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.netmonSplitContainer)).BeginInit();
            this.netmonSplitContainer.Panel1.SuspendLayout();
            this.netmonSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcpGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // netmonSplitContainer
            // 
            this.netmonSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.netmonSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.netmonSplitContainer.Name = "netmonSplitContainer";
            this.netmonSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // netmonSplitContainer.Panel1
            // 
            this.netmonSplitContainer.Panel1.Controls.Add(this.tcpGridView);
            this.netmonSplitContainer.Size = new System.Drawing.Size(682, 261);
            this.netmonSplitContainer.SplitterDistance = 232;
            this.netmonSplitContainer.TabIndex = 0;
            // 
            // tcpGridView
            // 
            this.tcpGridView.AllowUserToAddRows = false;
            this.tcpGridView.AllowUserToDeleteRows = false;
            this.tcpGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tcpGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcpGridView.Location = new System.Drawing.Point(0, 0);
            this.tcpGridView.Name = "tcpGridView";
            this.tcpGridView.ReadOnly = true;
            this.tcpGridView.Size = new System.Drawing.Size(682, 232);
            this.tcpGridView.TabIndex = 0;
            // 
            // refreshTimer
            // 
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // NetworkMonitor_Advanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 261);
            this.Controls.Add(this.netmonSplitContainer);
            this.Name = "NetworkMonitor_Advanced";
            this.Text = "NetworkMonitor_Advanced";
            this.Load += new System.EventHandler(this.NetworkMonitor_Advanced_Load);
            this.netmonSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.netmonSplitContainer)).EndInit();
            this.netmonSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcpGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer netmonSplitContainer;
        private System.Windows.Forms.DataGridView tcpGridView;
        private System.Windows.Forms.Timer refreshTimer;
    }
}