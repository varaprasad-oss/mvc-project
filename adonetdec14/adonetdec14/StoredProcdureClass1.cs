using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace adonetdec14
{
    /// <summary>
    ///  Insert the records using the stored procedure
    /// </summary>
    class StoredProcdureClass1
    {
        // Review: Use meaningful variable names
        private string connectSP=string.Empty;
        private SqlConnection sc;
        public void StoreProcess()
        {
            connectSP = "Data Source=192.168.50.95;Initial Catalog=vgudipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            sc = new SqlConnection(connectSP);
            Console.WriteLine("Enter the Employee id:");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Employee name" );
            var empName = Console.ReadLine();
            sc.Open();
            // Review: Use meaningful sp name
            SqlCommand cmd = new SqlCommand("EmployeeProc", sc);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@empName", empName);
            cmd.ExecuteNonQuery();
            sc.Close();
        }
        public void StoreProcess1(int id ,string empName)
        {
            connectSP = "Data Source=192.168.50.95;Initial Catalog=vgudipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            sc = new SqlConnection(connectSP);
            //Console.WriteLine("Enter the Employee id:");
            //var id = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Employee name");
            //var empName = Console.ReadLine();
            sc.Open();
            // Review: Use meaningful sp name
            SqlCommand cmd = new SqlCommand("EmployeeProc", sc);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@empName", empName);
            cmd.ExecuteNonQuery();
            sc.Close();
        }
    }
}
