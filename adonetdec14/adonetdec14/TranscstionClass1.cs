using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace adonetdec14
{
    class TranscstionClass1
    {
        private string connectionString;
        //private  SqlConnection sqlConnection;
        public void TranscationExample()
        {
            
            connectionString = "Data Source=192.168.50.95;Initial Catalog=vgudipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                var transcation = sqlConnection.BeginTransaction();
                try
                {
                    // Insert  records into the students table 
                    var sql = "INSERT INTO Students(name,id) VALUES(@name,@id)";
                    using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@name", "RamaRAO");
                        sqlCommand.Parameters.AddWithValue("@id", 5);
                        sqlCommand.Transaction = transcation;
                        sqlCommand.ExecuteNonQuery();

                    }
                    //insert records into the Professors table 
                    var sql1 = "INSERT INTO Professors(name) VALUES(@name)";
                    using (SqlCommand sqlCommand1 = new SqlCommand(sql1, sqlConnection))
                    {
                        sqlCommand1.Parameters.AddWithValue("@name", "Raju");
                        sqlCommand1.Transaction = transcation;
                        sqlCommand1.ExecuteNonQuery();

                    }
                    transcation.Commit();
                    sqlConnection.Close();
                }




                catch (Exception e)
                {

                    transcation.Rollback();
                    Console.WriteLine("Error occured " + e.Message);
                }
                finally
                {
                    transcation.Dispose();
                }
            }

            }

        }
    }

