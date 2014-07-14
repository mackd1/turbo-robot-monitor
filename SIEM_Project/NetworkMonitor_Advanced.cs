using SIEM_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIEM_Project
{
    public partial class NetworkMonitor_Advanced : Form
    {
        private DataTable tcpTable;

        public NetworkMonitor_Advanced()
        {
            InitializeComponent();

            // Double buffering helps with pretty-ifying the form
            tcpGridView.DoubleBuffered(true);
        }

        private void NetworkMonitor_Advanced_Load(object sender, EventArgs e)
        {
            tcpTable = new DataTable("tcp_info");

            // Initialize the data table with columns
            tcpTable.Columns.Add("Process ID");
            tcpTable.Columns.Add("Local Address");
            tcpTable.Columns.Add("Remote Address");
            tcpTable.Columns.Add("Local Port");
            tcpTable.Columns.Add("Remote Port");
            tcpTable.Columns.Add("Connection State");

            TCPInfo.MIB_TCPROW_OWNER_PID[] tcpConnTable = TCPInfo.GetAllTcpConnections();

            foreach(TCPInfo.MIB_TCPROW_OWNER_PID tcpRow in tcpConnTable)
            {
                tcpTable.Rows.Add(CreateRow(tcpRow));
            }

            tcpGridView.DataSource = tcpTable;
            //refreshTimer.Enabled = true;
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void RefreshTable()
        {

        }

        private DataRow CreateRow(TCPInfo.MIB_TCPROW_OWNER_PID tcpRow)
        {
            DataRow tempRow = tcpTable.NewRow();

            tempRow[0] = tcpRow.owningPid;
            tempRow[1] = REVERSERIZER(IPAddress.Parse(tcpRow.localAddr.ToString()).ToString());
            tempRow[2] = REVERSERIZER(IPAddress.Parse(tcpRow.remoteAddr.ToString()).ToString());
            tempRow[3] = tcpRow.LocalPort;
            tempRow[4] = tcpRow.RemotePort;
            tempRow[5] = GetTCPState(tcpRow.state);

            return tempRow;
        }

        private string REVERSERIZER(string thingy)
        {
            string newString = "";

            string[] array = thingy.Split('.');

            newString += (array[3] + ".");
            newString += (array[2] + ".");
            newString += (array[1] + ".");
            newString += array[0];

            return newString;
        }

        public string GetTCPState(uint stateNum)
        {
            switch (stateNum)
            {
                case 0:
                    return "All";
                case 1:
                    return "Closed";
                case 2:
                    return "Listen";
                case 3:
                    return "Syn Sent";
                case 4:
                    return "Syn Recv";
                case 5:
                    return "Established";
                case 6:
                    return "Fin Wait 1";
                case 7:
                    return "Fin Wait 2";
                case 8:
                    return "Close Wait";
                case 9:
                    return "Closing";
                case 10:
                    return "Last Ack";
                case 11:
                    return "Time Wait";
                case 12:
                    return "Delete TCB";
                default:
                    return "Invalid State";
            }
        }
    }
}
