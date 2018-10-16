using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace bigapple
{
    public class DatabaseClass
    {
        SqlConnection connection;
        string connectionString = ConfigurationManager.ConnectionStrings["bigapple.Properties.Settings.BigAppleConnectionString"].ConnectionString;

        public object PopulateRecord(string Query_)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(Query_, connection))
            {
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                object data = dataSet.Tables[2];
                return data;
            }
        }

    }
}
