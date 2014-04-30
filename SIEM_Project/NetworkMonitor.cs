using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Net;
using System.Net.NetworkInformation;
using SIEM_Project.Classes;

namespace SIEM_Project
{
    public partial class NetworkMonitor : Form
    {
        private DataTable tcpTable;
        private int avgTcpConns;
        private bool wasFlagged = false;

        public NetworkMonitor()
        {
            InitializeComponent();
        }

        private void NetworkMonitor_Load(object sender, EventArgs e)
        {
            DataManager dataMan = new DataManager();

            avgTcpConns = dataMan.GetNetworkHistory();

            tcpTable = new DataTable("tcp_info");

            tcpTable.Columns.Add("Process ID");
            tcpTable.Columns.Add("Local Address");
            tcpTable.Columns.Add("Remote Address");
            tcpTable.Columns.Add("Local Port");
            tcpTable.Columns.Add("Remote Port");
            tcpTable.Columns.Add("Connection State");

            tcpGridView.DataSource = tcpTable;
            RefreshTable();

            refreshTimer.Enabled = true;
        }

        private int RefreshTable()
        {
            // Remove all current rows in the table
            for (int i = (tcpTable.Rows.Count - 1); i > 0; i--)
            {
                tcpTable.Rows.RemoveAt(i);
            }

            TCPInfo.MIB_TCPROW_OWNER_PID[] tcpConnTable = TCPInfo.GetAllTcpConnections();
            
            for (int i = 0; i < tcpConnTable.Count(); i++)
            {
                DataRow tempRow = tcpTable.NewRow();

                tempRow[0] = tcpConnTable[i].owningPid;
                tempRow[1] = REVERSERIZER(IPAddress.Parse(tcpConnTable[i].localAddr.ToString()).ToString());
                tempRow[2] = REVERSERIZER(IPAddress.Parse(tcpConnTable[i].remoteAddr.ToString()).ToString());
                tempRow[3] = tcpConnTable[i].LocalPort;
                tempRow[4] = tcpConnTable[i].RemotePort;
                tempRow[5] = GetTCPState(tcpConnTable[i].state);      

                tcpTable.Rows.Add(tempRow);
            }

            return tcpConnTable.Count();
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

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            int tcpConns = RefreshTable();

            this.Text = "Number of TCP connections: " + tcpConns.ToString() + " | " + avgTcpConns.ToString() + " is historical average";

            if (avgTcpConns < tcpConns)
                AlertSender.SendMessage("Exceeded baseline TCP connections, possible attack", "Network");
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
