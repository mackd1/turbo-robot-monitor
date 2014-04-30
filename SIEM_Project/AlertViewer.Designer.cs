namespace SIEM_Project
{
    partial class AlertViewer
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
            this.alertGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.ClearLogLbl = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.alertGridView)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // alertGridView
            // 
            this.alertGridView.AllowUserToAddRows = false;
            this.alertGridView.AllowUserToDeleteRows = false;
            this.alertGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alertGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alertGridView.Location = new System.Drawing.Point(0, 0);
            this.alertGridView.Name = "alertGridView";
            this.alertGridView.ReadOnly = true;
            this.alertGridView.Size = new System.Drawing.Size(479, 262);
            this.alertGridView.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearLogLbl});
            this.toolStrip.Location = new System.Drawing.Point(421, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(58, 262);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // ClearLogLbl
            // 
            this.ClearLogLbl.Name = "ClearLogLbl";
            this.ClearLogLbl.Size = new System.Drawing.Size(55, 15);
            this.ClearLogLbl.Text = "Clear Log";
            this.ClearLogLbl.Click += new System.EventHandler(this.ClearLogLbl_Click);
            // 
            // AlertViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 262);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.alertGridView);
            this.DoubleBuffered = true;
            this.Name = "AlertViewer";
            this.Text = "Alert Log";
            this.Load += new System.EventHandler(this.AlertViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alertGridView)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView alertGridView;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel ClearLogLbl;

    }
}