using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace adonetdec14
{
    class EmployeeClass1
    {
        /// <summary>
        /// Insert the records using the sql queary
        /// </summary>
        /// 
        private string connct = string.Empty;
        private SqlConnection sc;
        public void Inserting()
        {

            connct = "Data Source=192.168.50.95;Initial Catalog=vgudipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            sc = new SqlConnection(connct);
            Console.WriteLine("Enter the employee id is");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the employee name");
            var empName = Console.ReadLine();
            Console.WriteLine("enter the phone number");
            var empPhoneNumber = Console.ReadLine();
            sc.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Employees1(empid,empname,phonenumberr) VALUES (@id,@empName,@empPhoneNumber)", sc);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@empName", empName);
            cmd.Parameters.AddWithValue("@empPhoneNumber", empPhoneNumber);
            cmd.ExecuteNonQuery();
            sc.Close();
        }
    }
}
