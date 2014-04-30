namespace SIEM_Project
{
    partial class NetworkMonitor
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
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.tcpGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tcpGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshTimer
            // 
            this.refreshTimer.Interval = 2500;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
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
            this.tcpGridView.Size = new System.Drawing.Size(576, 304);
            this.tcpGridView.TabIndex = 3;
            // 
            // NetworkMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 304);
            this.Controls.Add(this.tcpGridView);
            this.Name = "NetworkMonitor";
            this.Text = "Network Monitor";
            this.Load += new System.EventHandler(this.NetworkMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tcpGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.DataGridView tcpGridView;

    }
}