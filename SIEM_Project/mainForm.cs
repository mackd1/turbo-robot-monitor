using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIEM_Project
{
    public partial class mainForm : Form
    {
        //private ProcessViewer pView;
        private NetworkMonitor netMon;
        private ProcessMonitor pMon;
        private AlertViewer aView;

        public mainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // Open all of the MDI Sub-windows
            netMon = new NetworkMonitor();
            pMon = new ProcessMonitor();
            aView = new AlertViewer();

            netMon.MdiParent = this;
            pMon.MdiParent = this;
            aView.MdiParent = this;

            netMon.Show();
            pMon.Show();
            //aView.Show();

            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void generateTrainingDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaselineGeneratorForm bGen = new BaselineGeneratorForm();
            bGen.ShowDialog();
        }

        private void processViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pMon.Visible == true)
            {
                pMon.Hide();
            }
            else
            {
                pMon.Show();
            }
        }

        private void networkMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (netMon.Visible == true)
            {
                netMon.Hide();
            }
            else
            {
                netMon.Show();
            }
        }

        private void alertViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aView.Visible == true)
            {
                aView.Hide();
            }
            else
            {
                aView.Show();
            }
        }
    }
}
