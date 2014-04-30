using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SIEM_Project.Classes;

namespace SIEM_Project
{
    public partial class AlertViewer : Form
    {
        private DataTable alertTable;

        public AlertViewer()
        {
            InitializeComponent();
        }

        private void AlertViewer_Load(object sender, EventArgs e)
        {
            AlertSender.Call_SendMessage += new Event_SendMessage(On_NewMessage);

            alertTable = new DataTable("alerts");

            alertTable.Columns.Add("Error Type");
            alertTable.Columns.Add("Message");
            alertTable.Columns.Add("Timestamp");

            alertGridView.DataSource = alertTable;
        }

        private void On_NewMessage(Alert alert)
        {
            DataRow tempRow = alertTable.NewRow();

            tempRow[0] = alert.errorType;
            tempRow[1] = alert.alertMessage;
            tempRow[2] = DateTime.Now.ToShortTimeString();

            alertTable.Rows.Add(tempRow);
        }

        private void ClearLogLbl_Click(object sender, EventArgs e)
        {
            alertTable.Clear();
        }
    }
}
