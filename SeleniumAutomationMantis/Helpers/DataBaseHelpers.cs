using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace SeleniumAutomationMantis.Helpers
{
    public class DataBaseHelpers
    {
        private static MySqlConnection GetDBConnection()
        {
            string connectionString = "Data Source=" + BuilderJson.ReturnParameterAppSettings("DB_URL") + "," + BuilderJson.ReturnParameterAppSettings("DB_PORT") + ";" +
                                      "Initial Catalog=" + BuilderJson.ReturnParameterAppSettings("DB_NAME") + ";" +
                                      "User ID=" + BuilderJson.ReturnParameterAppSettings("DB_USER") + "; " +
                                      "Password=" + BuilderJson.ReturnParameterAppSettings("DB_PASSWORD") + ";";
          
            MySqlConnection connection = new MySqlConnection(connectionString);

            return connection;
        }

        public static void ExecuteQuery(string query)
        {
            using (MySqlCommand cmd = new MySqlCommand(query, GetDBConnection()))
            {
                cmd.CommandTimeout = Int32.Parse(BuilderJson.ReturnParameterAppSettings("DB_CONNECTION_TIMEOUT"));
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }

        public static List<string> RetornaDadosQuery(string query)
        {
            DataSet ds = new DataSet();
            List<string> lista = new List<string>();

            using (MySqlCommand cmd = new MySqlCommand(query, GetDBConnection()))
            {
                cmd.CommandTimeout = Int32.Parse(BuilderJson.ReturnParameterAppSettings("DB_CONNECTION_TIMEOUT"));
                cmd.Connection.Open();

                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);

                cmd.Connection.Close();
            }

            if (ds.Tables[0].Columns.Count == 0)
            {
                return null;
            }

            try
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                    {
                        lista.Add(ds.Tables[0].Rows[i][j].ToString());
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }

            return lista;
        }
    }
}
