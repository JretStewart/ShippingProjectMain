using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ShippingProject
{
    /// <summary>
    /// Class: This class contains the logic for connection to the database.
    /// Developers: Kalin Bowden,
    /// Date: 12.12.2016.
    /// </summary>
    class DataAdapter
    {
        // Class level variables.
        private static  SqlConnection dbCon = new SqlConnection("Data Source=stusql.otc.edu;" +
            "Initial Catalog=CIS151_103G4;" +
            "Integrated Security=True");
        private static SqlCommand dbCmd;

        /// <summary>
        /// Connect to the database.
        /// </summary>
        public static void Connect()
        {
            try
            {
                // Open the connection to the log Dbat base.
                dbCon.Open();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        /// <summary>
        /// Insert the daily log to the database.
        /// </summary>
        /// <param name="data"></param>
        public static void Insert(String data)
        {
            try
            {
                // SQL command for inserting the log.
                string logInsert = "INSERT INTO DailyPackageLog2(Invoice) VALUES(@data)";

                // Connect to log db.
                Connect();

                // Create a new db command object.
                dbCmd = new SqlCommand(logInsert, dbCon);

                //still ???
                dbCmd.Parameters.AddWithValue("@data", data);

                // Insert Log
                dbCmd.ExecuteNonQuery();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            finally
            {
                Disconnect();
            }
        }// End of Method.

        /// <summary>
        /// Pull the daily logs from the databse.
        /// </summary>
        /// <returns></returns>
        public static string[] Pull()
        {
            // Method level variables.
            int index = 0;
            string[] serArray = new string[10000];
            string sqlPull = "SELECT Invoice FROM DailyPackageLog2";

            // Connect to the database.
            Connect();

            // Create a new comand object.
            SqlCommand cmd = new SqlCommand(sqlPull, dbCon);

            // Execute the SQL command to pull data.
            SqlDataReader sqlReader = cmd.ExecuteReader();

            // Write the log entries to the array.
            while (sqlReader.Read())
            {
                serArray[index++] = sqlReader["Invoice"].ToString();
            }

            // Disconnect from the database.
            Disconnect();

            // Return the array.
            return serArray;

        }// End of Method.

        /// <summary>
        /// Disconnect from the database.
        /// </summary>
        public static void Disconnect()
        {
            try
            {
                // Close the connection.
                dbCon.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            dbCon.Close();
        }
    }// End of class.
}// End of Solution.
