using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace adonetdec14
{
    /// <summary>
    ///    creating table using the ado.net 
    /// </summary>

    class CreateTableClass2
    {
        private string connect;
        public void Display() 
        {
            try
            {
                connect = "Data Source=192.168.50.95;Initial Catalog=vgudipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
                SqlConnection sqlconnection = new SqlConnection(connect);
                SqlCommand cmd = new SqlCommand("create table StudentList(id int not null,name varchar(100), email varchar(50), join_date date)", sqlconnection);
                sqlconnection.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table is created suceesfully");
                sqlconnection.Close();


            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());

            }
            
        }
        public void DisplayRetrive()
        {
            connect= "Data Source=192.168.50.95;Initial Catalog=vgudipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";

            SqlConnection connection = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand("SELECT * FROM TollplusTrainees11_dec", connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("Retraving the data from the table");
            while (reader.Read())
            {
                Console.WriteLine(reader["empid"]+"||"+reader["empname"]+"***"+reader["empsalary"]+""+reader["empgender"]+""+reader["emplocation"]);
            }
            connection.Close();
        }
        public void ReadById()
        {
            connect = "Data Source=192.168.50.95;Initial Catalog=vgudipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            SqlConnection connection = new SqlConnection(connect);
            var sqlQuery = " SELECT *FROM TollplusTrainees11_dec WHERE EMPID=1";
            SqlCommand cmd = new SqlCommand(sqlQuery, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"name:{reader.GetString("empname")}  salary:{reader.GetDecimal("empsalary")}  gender:{reader.GetString("empgender")}");
            }


        }
        public void ReadById1(int id)
        {
            connect = "Data Source=192.168.50.95;Initial Catalog=vgudipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            SqlConnection connection = new SqlConnection(connect);
            var query = "SELECT * FROM Employees1 where EmpId=@id";
            
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", id);

            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               
                Console.WriteLine($"{reader.GetString("empname")}{reader.GetString("location")}");
            }


        
        }

        public void FilterBy()
        {
            connect = "Data Source=192.168.50.95;Initial Catalog=vgudipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";

            SqlConnection connection = new SqlConnection(connect);
            var sqlQuery = " SELECT * FROM TollplusTrainees11_dec WHERE EmpName LIKE  'r%'";
            SqlCommand cmd = new SqlCommand(sqlQuery, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString("empname"));

            }

        }
       

    }
}
