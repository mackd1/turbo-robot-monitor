using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Data.OleDb;

using ADOX;

namespace SIEM_Project.Classes
{
    public class DataManager
    {
        private string databaseFile = "data.mdb";
        private string connString;
        private OleDbConnection dbConn;

        // Table names
        private string processHistoryTable = "process_history";
        private string networkHistoryTable = "network_history";

        public DataManager()
        {
            InitializeDatabase();
        }

        /// <summary>
        /// Housekeeping done here, makes sure that the database already exists, if not then it is created and initialized.
        /// </summary>
        private void InitializeDatabase()
        {
            connString = "Provider=Microsoft.Jet.OLEDB.4.0;";
            connString += "Data Source=" + databaseFile + ";Jet OLEDB:Engine Type=5";

            if (!File.Exists(databaseFile))
            {
                // Database hasn't been created yet, so create it
                CreateDatabaseFile();
            }

            dbConn = new OleDbConnection(connString);

        }

        private void CreateDatabaseFile()
        {
            Catalog dataCat = new Catalog(); //01101101011001010110111101110111

            // Create the database file
            dataCat.Create(connString);

            // Create the database tables
            Table historyTable = new Table();
            Table networkTable = new Table();

            historyTable.Name = processHistoryTable;
            networkTable.Name = networkHistoryTable;

            historyTable.Columns.Append("process_name", DataTypeEnum.adVarWChar, 128);
            historyTable.Columns.Append("avg_modules", DataTypeEnum.adVarWChar, 64);
            historyTable.Columns.Append("avg_handles", DataTypeEnum.adVarWChar, 64);
            historyTable.Columns.Append("avg_threads", DataTypeEnum.adVarWChar, 64);
            historyTable.Columns.Append("basePriority", DataTypeEnum.adVarWChar, 64);
            historyTable.Columns.Append("avg_memUsed", DataTypeEnum.adVarWChar, 64);
            historyTable.Columns.Append("avg_processorTime", DataTypeEnum.adVarWChar, 64);

            networkTable.Columns.Append("tcp_conns", DataTypeEnum.adVarWChar, 64);

            dataCat.Tables.Append(historyTable);
            dataCat.Tables.Append(networkTable);
        }

        public void InsertNetworkHistory(int numConnections)
        {
            dbConn.Open();

            string deleteString = "DELETE * FROM " + networkHistoryTable + ";";
            string insertString = "INSERT INTO " + networkHistoryTable + " VALUES ('" + numConnections.ToString() + "');";
            
            OleDbCommand delCommand = new OleDbCommand(deleteString, dbConn);
            OleDbCommand insCommand = new OleDbCommand(insertString, dbConn);

            // Delete previous entry
            delCommand.ExecuteNonQuery();
            insCommand.ExecuteNonQuery();

            dbConn.Close();
        }

        public string InsertProcessHistory(ProcessHistory pHistory)
        {
            string insertString = "INSERT INTO " + processHistoryTable + " VALUES ('" + pHistory.name +
                "', '" + pHistory.avgModules + "', '" + pHistory.avgHandles + "', '" + pHistory.avgThreads + 
                "', '" + pHistory.basePriority + "', '" + pHistory.avgMemUsed + "', '" + pHistory.avgProcessorTime + "');";

            dbConn.Open();

            OleDbCommand insertCommand = new OleDbCommand(insertString, dbConn);
            
            insertCommand.ExecuteNonQuery();
            
            dbConn.Close();

            return insertString;
        }

        public int GetNetworkHistory()
        {
            dbConn.Open();

            string selectString = "SELECT * FROM " + networkHistoryTable + ";";

            OleDbCommand selectCommand = new OleDbCommand(selectString, dbConn);
            string result = selectCommand.ExecuteScalar().ToString();

            return Convert.ToInt32(result);
        }

        public ProcessHistory GetProcessHistory(string name)
        {
            dbConn.Open();

            string selectString = "SELECT * FROM " + processHistoryTable + " WHERE process_name = '" + name + "';";
            
            OleDbCommand selectCommand = new OleDbCommand(selectString, dbConn);
            OleDbDataReader dataReader = selectCommand.ExecuteReader();
            
            while(dataReader.Read())
            {
                if(dataReader[0].ToString().Equals(name))
                {
                    ProcessHistory tempHist = new ProcessHistory(name);

                    tempHist.SetHistory(Convert.ToInt32(dataReader[1]), Convert.ToInt32(dataReader[2]), 
                        Convert.ToInt32(dataReader[3]), Convert.ToInt32(dataReader[4]),
                        Convert.ToInt64(dataReader[5]), Convert.ToInt32(dataReader[6]));

                    dbConn.Close();

                    return tempHist;
                }
            }

            dbConn.Close();

            // If we haven't returned by now then the item wasn't found
            return null;
        }

        public void DeleteTrainingData()
        {
            dbConn.Open();

            string deleteString = "DELETE * FROM " + processHistoryTable + ";";

            OleDbCommand delCommand = new OleDbCommand(deleteString, dbConn);

            delCommand.ExecuteNonQuery();

            dbConn.Close();
        }
    }
}
