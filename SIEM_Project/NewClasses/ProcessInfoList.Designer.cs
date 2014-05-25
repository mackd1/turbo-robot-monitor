namespace SIEM_Project.NewClasses
{
    partial class ProcessInfoList
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
            this.processListGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.processListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // processListGrid
            // 
            this.processListGrid.AllowUserToDeleteRows = false;
            this.processListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processListGrid.Location = new System.Drawing.Point(0, 0);
            this.processListGrid.Name = "processListGrid";
            this.processListGrid.ReadOnly = true;
            this.processListGrid.Size = new System.Drawing.Size(325, 415);
            this.processListGrid.TabIndex = 0;
            // 
            // ProcessInfoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.processListGrid);
            this.Name = "ProcessInfoList";
            this.Size = new System.Drawing.Size(325, 415);
            this.Load += new System.EventHandler(this.ProcessInfoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.processListGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView processListGrid;
    }
}
