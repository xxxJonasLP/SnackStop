using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SnackStop
{
    internal class DB_Connector
    {
        
        //Ich kann das ganze nicht mehr

            public string server = "localhost";
            public string database = "snackstop";
            public string uid = "root";
            public string pwd = "";
            public string conString;
            

            public DB_Connector()
            {
                UpdateConString();
            }

            public void UpdateConString()
            {
                conString = $"server={server};database={database};uid={uid};pwd={pwd}";
            }

            public void ChangeServer_Database(string newServer, string newDatabase, string newUid, string newPwd)
            {
                server = newServer;
                database = newDatabase;
                uid = newUid;
                pwd = newPwd;

                UpdateConString();
            }

            public List<List<string?>> GetData(string query)
            {
                // make 2d array for data 
                //WAS NO WAY ich esse pjs füße
                //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                var resultData = new List<List<string?>>();

                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    try
                    {
                        conn.Open();
                        Console.WriteLine("Connected");

                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // get num of columns in table
                            int columnCount = reader.FieldCount;

                            while (reader.Read())
                            {
                                // make list for rows
                                var row = new List<string?>();

                                for (int i = 0; i < columnCount; i++)
                                {
                                    // add row to list
                                    row.Add(reader[i].ToString());
                                }

                                // add rowlist to resultdata
                                resultData.Add(row);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fehler: " + ex.ToString());
                    }
                }

                return resultData;
            }


            public void executeQuery(string query)
            {
                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    try
                    {
                        conn.Open();
                        Console.WriteLine("Connected");

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }

            public void addData(string tableName, List<string> columns, List<List<string>> valuesList)
            {
                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    conn.Open();

                    // for each value list in value list
                    foreach (var values in valuesList)
                    {
                        // make query string (make string 'value' via lambda & join with ,)
                        string queryString = $"INSERT INTO {tableName} ({string.Join(", ", columns)}) VALUES ({string.Join(", ", values.Select(value => $"'{value}'"))})";

                        MySqlCommand cmd = new(queryString, conn);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        
    }
}
