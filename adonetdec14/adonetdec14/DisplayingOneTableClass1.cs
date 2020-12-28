using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace adonetdec14
{
    class DisplayingOneTableClass1
    {
        private string connectString;
        public void DisplaySingleTable()
        {
            connectString = "Data Source=192.168.50.95;Initial Catalog=vgudipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            using (SqlConnection connect=new SqlConnection(connectString))
            {
               
                using (SqlCommand command = new SqlCommand("USP_OneTable",connect))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connect.Open();
                    using (SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        Console.WriteLine("Dispalying the customers table");
                        while (dataReader.Read())
                        {
                            Console.WriteLine(dataReader.GetString(dataReader.GetOrdinal("customername"))+"|"+dataReader.GetInt32("id"));

                        }

                    }

                }

            }
            
        }
    }
}
