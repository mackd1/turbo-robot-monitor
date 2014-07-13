namespace SIEM_Project
{
    partial class ProcessMonitor
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.processListView = new System.Windows.Forms.ListView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.genTab = new System.Windows.Forms.TabPage();
            this.priorProcessInfoGroup = new System.Windows.Forms.GroupBox();
            this.avgCPUTimeLbl = new System.Windows.Forms.Label();
            this.avgThreadsLbl = new System.Windows.Forms.Label();
            this.avgHandlesLbl = new System.Windows.Forms.Label();
            this.avgMemUsedLbl = new System.Windows.Forms.Label();
            this.avgBasePriorityLbl = new System.Windows.Forms.Label();
            this.avgModulesLbl = new System.Windows.Forms.Label();
            this.currentProcessInfoGroup = new System.Windows.Forms.GroupBox();
            this.cpuTimeLbl = new System.Windows.Forms.Label();
            this.numThreadsLbl = new System.Windows.Forms.Label();
            this.modulesLbl = new System.Windows.Forms.Label();
            this.numHandlesLbl = new System.Windows.Forms.Label();
            this.memUsedLbl = new System.Windows.Forms.Label();
            this.basePriorityLbl = new System.Windows.Forms.Label();
            this.processNameLbl = new System.Windows.Forms.Label();
            this.resourceInfo = new System.Windows.Forms.TabPage();
            this.resourceGridView = new System.Windows.Forms.DataGridView();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.genTab.SuspendLayout();
            this.priorProcessInfoGroup.SuspendLayout();
            this.currentProcessInfoGroup.SuspendLayout();
            this.resourceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourceGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.processListView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tabControl);
            this.splitContainer.Size = new System.Drawing.Size(699, 400);
            this.splitContainer.SplitterDistance = 232;
            this.splitContainer.TabIndex = 1;
            // 
            // processListView
            // 
            this.processListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processListView.Location = new System.Drawing.Point(0, 0);
            this.processListView.Name = "processListView";
            this.processListView.Size = new System.Drawing.Size(232, 400);
            this.processListView.TabIndex = 0;
            this.processListView.UseCompatibleStateImageBehavior = false;
            this.processListView.SelectedIndexChanged += new System.EventHandler(this.processListView_SelectedIndexChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.genTab);
            this.tabControl.Controls.Add(this.resourceInfo);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(463, 400);
            this.tabControl.TabIndex = 0;
            // 
            // genTab
            // 
            this.genTab.Controls.Add(this.priorProcessInfoGroup);
            this.genTab.Controls.Add(this.currentProcessInfoGroup);
            this.genTab.Controls.Add(this.processNameLbl);
            this.genTab.Location = new System.Drawing.Point(4, 22);
            this.genTab.Name = "genTab";
            this.genTab.Padding = new System.Windows.Forms.Padding(3);
            this.genTab.Size = new System.Drawing.Size(455, 374);
            this.genTab.TabIndex = 0;
            this.genTab.Text = "General Information";
            this.genTab.UseVisualStyleBackColor = true;
            // 
            // priorProcessInfoGroup
            // 
            this.priorProcessInfoGroup.Controls.Add(this.avgCPUTimeLbl);
            this.priorProcessInfoGroup.Controls.Add(this.avgThreadsLbl);
            this.priorProcessInfoGroup.Controls.Add(this.avgHandlesLbl);
            this.priorProcessInfoGroup.Controls.Add(this.avgMemUsedLbl);
            this.priorProcessInfoGroup.Controls.Add(this.avgBasePriorityLbl);
            this.priorProcessInfoGroup.Controls.Add(this.avgModulesLbl);
            this.priorProcessInfoGroup.Location = new System.Drawing.Point(10, 195);
            this.priorProcessInfoGroup.Name = "priorProcessInfoGroup";
            this.priorProcessInfoGroup.Size = new System.Drawing.Size(251, 163);
            this.priorProcessInfoGroup.TabIndex = 12;
            this.priorProcessInfoGroup.TabStop = false;
            this.priorProcessInfoGroup.Text = "Baseline Information:";
            // 
            // avgCPUTimeLbl
            // 
            this.avgCPUTimeLbl.AutoSize = true;
            this.avgCPUTimeLbl.Location = new System.Drawing.Point(23, 137);
            this.avgCPUTimeLbl.Name = "avgCPUTimeLbl";
            this.avgCPUTimeLbl.Size = new System.Drawing.Size(116, 13);
            this.avgCPUTimeLbl.TabIndex = 12;
            this.avgCPUTimeLbl.Text = "Avg. CPU Time (in ms):";
            // 
            // avgThreadsLbl
            // 
            this.avgThreadsLbl.AutoSize = true;
            this.avgThreadsLbl.Location = new System.Drawing.Point(23, 49);
            this.avgThreadsLbl.Name = "avgThreadsLbl";
            this.avgThreadsLbl.Size = new System.Drawing.Size(102, 13);
            this.avgThreadsLbl.TabIndex = 8;
            this.avgThreadsLbl.Text = "Average # Threads:";
            // 
            // avgHandlesLbl
            // 
            this.avgHandlesLbl.AutoSize = true;
            this.avgHandlesLbl.Location = new System.Drawing.Point(23, 71);
            this.avgHandlesLbl.Name = "avgHandlesLbl";
            this.avgHandlesLbl.Size = new System.Drawing.Size(102, 13);
            this.avgHandlesLbl.TabIndex = 9;
            this.avgHandlesLbl.Text = "Average # Handles:";
            // 
            // avgMemUsedLbl
            // 
            this.avgMemUsedLbl.AutoSize = true;
            this.avgMemUsedLbl.Location = new System.Drawing.Point(23, 93);
            this.avgMemUsedLbl.Name = "avgMemUsedLbl";
            this.avgMemUsedLbl.Size = new System.Drawing.Size(117, 13);
            this.avgMemUsedLbl.TabIndex = 10;
            this.avgMemUsedLbl.Text = "Avg. Peak Mem Used: ";
            // 
            // avgBasePriorityLbl
            // 
            this.avgBasePriorityLbl.AutoSize = true;
            this.avgBasePriorityLbl.Location = new System.Drawing.Point(23, 115);
            this.avgBasePriorityLbl.Name = "avgBasePriorityLbl";
            this.avgBasePriorityLbl.Size = new System.Drawing.Size(111, 13);
            this.avgBasePriorityLbl.TabIndex = 11;
            this.avgBasePriorityLbl.Text = "Average Base Priority:";
            // 
            // avgModulesLbl
            // 
            this.avgModulesLbl.AutoSize = true;
            this.avgModulesLbl.Location = new System.Drawing.Point(23, 27);
            this.avgModulesLbl.Name = "avgModulesLbl";
            this.avgModulesLbl.Size = new System.Drawing.Size(103, 13);
            this.avgModulesLbl.TabIndex = 0;
            this.avgModulesLbl.Text = "Average # Modules:";
            // 
            // currentProcessInfoGroup
            // 
            this.currentProcessInfoGroup.Controls.Add(this.cpuTimeLbl);
            this.currentProcessInfoGroup.Controls.Add(this.numThreadsLbl);
            this.currentProcessInfoGroup.Controls.Add(this.modulesLbl);
            this.currentProcessInfoGroup.Controls.Add(this.numHandlesLbl);
            this.currentProcessInfoGroup.Controls.Add(this.memUsedLbl);
            this.currentProcessInfoGroup.Controls.Add(this.basePriorityLbl);
            this.currentProcessInfoGroup.Location = new System.Drawing.Point(10, 29);
            this.currentProcessInfoGroup.Name = "currentProcessInfoGroup";
            this.currentProcessInfoGroup.Size = new System.Drawing.Size(251, 160);
            this.currentProcessInfoGroup.TabIndex = 11;
            this.currentProcessInfoGroup.TabStop = false;
            this.currentProcessInfoGroup.Text = "Current Information";
            // 
            // cpuTimeLbl
            // 
            this.cpuTimeLbl.AutoSize = true;
            this.cpuTimeLbl.Location = new System.Drawing.Point(23, 133);
            this.cpuTimeLbl.Name = "cpuTimeLbl";
            this.cpuTimeLbl.Size = new System.Drawing.Size(91, 13);
            this.cpuTimeLbl.TabIndex = 7;
            this.cpuTimeLbl.Text = "CPU Time (in ms):";
            // 
            // numThreadsLbl
            // 
            this.numThreadsLbl.AutoSize = true;
            this.numThreadsLbl.Location = new System.Drawing.Point(23, 45);
            this.numThreadsLbl.Name = "numThreadsLbl";
            this.numThreadsLbl.Size = new System.Drawing.Size(49, 13);
            this.numThreadsLbl.TabIndex = 0;
            this.numThreadsLbl.Text = "Threads:";
            // 
            // modulesLbl
            // 
            this.modulesLbl.AutoSize = true;
            this.modulesLbl.Location = new System.Drawing.Point(23, 23);
            this.modulesLbl.Name = "modulesLbl";
            this.modulesLbl.Size = new System.Drawing.Size(50, 13);
            this.modulesLbl.TabIndex = 6;
            this.modulesLbl.Text = "Modules:";
            // 
            // numHandlesLbl
            // 
            this.numHandlesLbl.AutoSize = true;
            this.numHandlesLbl.Location = new System.Drawing.Point(23, 67);
            this.numHandlesLbl.Name = "numHandlesLbl";
            this.numHandlesLbl.Size = new System.Drawing.Size(49, 13);
            this.numHandlesLbl.TabIndex = 2;
            this.numHandlesLbl.Text = "Handles:";
            // 
            // memUsedLbl
            // 
            this.memUsedLbl.AutoSize = true;
            this.memUsedLbl.Location = new System.Drawing.Point(23, 89);
            this.memUsedLbl.Name = "memUsedLbl";
            this.memUsedLbl.Size = new System.Drawing.Size(92, 13);
            this.memUsedLbl.TabIndex = 3;
            this.memUsedLbl.Text = "Peak Mem Used: ";
            // 
            // basePriorityLbl
            // 
            this.basePriorityLbl.AutoSize = true;
            this.basePriorityLbl.Location = new System.Drawing.Point(23, 111);
            this.basePriorityLbl.Name = "basePriorityLbl";
            this.basePriorityLbl.Size = new System.Drawing.Size(68, 13);
            this.basePriorityLbl.TabIndex = 4;
            this.basePriorityLbl.Text = "Base Priority:";
            // 
            // processNameLbl
            // 
            this.processNameLbl.AutoSize = true;
            this.processNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processNameLbl.Location = new System.Drawing.Point(6, 6);
            this.processNameLbl.Name = "processNameLbl";
            this.processNameLbl.Size = new System.Drawing.Size(134, 20);
            this.processNameLbl.TabIndex = 10;
            this.processNameLbl.Text = "Process Name: ";
            // 
            // resourceInfo
            // 
            this.resourceInfo.Controls.Add(this.resourceGridView);
            this.resourceInfo.Location = new System.Drawing.Point(4, 22);
            this.resourceInfo.Name = "resourceInfo";
            this.resourceInfo.Padding = new System.Windows.Forms.Padding(3);
            this.resourceInfo.Size = new System.Drawing.Size(455, 374);
            this.resourceInfo.TabIndex = 1;
            this.resourceInfo.Text = "Resource Information";
            this.resourceInfo.UseVisualStyleBackColor = true;
            // 
            // resourceGridView
            // 
            this.resourceGridView.AllowUserToAddRows = false;
            this.resourceGridView.AllowUserToDeleteRows = false;
            this.resourceGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourceGridView.Location = new System.Drawing.Point(3, 3);
            this.resourceGridView.Name = "resourceGridView";
            this.resourceGridView.ReadOnly = true;
            this.resourceGridView.Size = new System.Drawing.Size(449, 368);
            this.resourceGridView.TabIndex = 0;
            // 
            // refreshTimer
            // 
            this.refreshTimer.Interval = 2500;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // ProcessMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 400);
            this.Controls.Add(this.splitContainer);
            this.DoubleBuffered = true;
            this.Name = "ProcessMonitor";
            this.Text = "Process Monitor";
            this.Load += new System.EventHandler(this.ProcessMonitor_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.genTab.ResumeLayout(false);
            this.genTab.PerformLayout();
            this.priorProcessInfoGroup.ResumeLayout(false);
            this.priorProcessInfoGroup.PerformLayout();
            this.currentProcessInfoGroup.ResumeLayout(false);
            this.currentProcessInfoGroup.PerformLayout();
            this.resourceInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resourceGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage genTab;
        private System.Windows.Forms.TabPage resourceInfo;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.ListView processListView;
        private System.Windows.Forms.GroupBox priorProcessInfoGroup;
        private System.Windows.Forms.Label avgCPUTimeLbl;
        private System.Windows.Forms.Label avgThreadsLbl;
        private System.Windows.Forms.Label avgHandlesLbl;
        private System.Windows.Forms.Label avgMemUsedLbl;
        private System.Windows.Forms.Label avgBasePriorityLbl;
        private System.Windows.Forms.Label avgModulesLbl;
        private System.Windows.Forms.GroupBox currentProcessInfoGroup;
        private System.Windows.Forms.Label cpuTimeLbl;
        private System.Windows.Forms.Label numThreadsLbl;
        private System.Windows.Forms.Label modulesLbl;
        private System.Windows.Forms.Label numHandlesLbl;
        private System.Windows.Forms.Label memUsedLbl;
        private System.Windows.Forms.Label basePriorityLbl;
        private System.Windows.Forms.Label processNameLbl;
        private System.Windows.Forms.DataGridView resourceGridView;
    }
}