using DocumentFormat.OpenXml.Office2010.CustomUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace adonetdec14
{
    class ListWithReaderWithMultipleResults
    {
        private string connectionString;

        public void Display()
        {
            connectionString = "Data Source=192.168.50.95;Initial Catalog=vgudipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("USP_MultipleTables", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        Console.WriteLine("Displaying the student tabel data ");
                        while (dataReader.Read())
                        {
                            Console.WriteLine(dataReader.GetString("name") + "|" + dataReader.GetInt32("id"));
                        }
                        dataReader.NextResult();
                        Console.WriteLine("Displaying the student marks table data ");
                        while (dataReader.Read())
                        {
                            Console.WriteLine(dataReader.GetString("marks") + "|" + dataReader.GetInt32("id")+"|"+dataReader.GetInt32("rank")+"|"+dataReader.GetString("school_id"));

                        }
            }


                    }
                }
        }
    }
}

