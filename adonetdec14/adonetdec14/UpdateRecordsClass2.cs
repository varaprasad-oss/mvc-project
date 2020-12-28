using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace adonetdec14
{
    class UpdateRecordsClass2
    {
        private string connect;

        public void UpdateRecords()
        {
            connect = "Data Source=192.168.50.95;Initial Catalog=vgudipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            SqlConnection connection = new SqlConnection(connect);
            Console.WriteLine("Enter the  id number you want to update :");
            var empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the father name  ");
            string Name = Console.ReadLine();
            Console.WriteLine("enter the adhar number ");
            var gender  = Console.ReadLine();
            connection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE TollplusTrainees11_dec SET EmpName=@Name, empgender=@gender where empid=@empid", connection);
            //SqlCommand cmd = new SqlCommand("INSERT INTO Products(product name, productprice) VALUES(@product name,@productprice)", sc);
            cmd.Parameters.AddWithValue("@empid", empid);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@gender", gender);
           
            cmd.ExecuteNonQuery();
            connection.Close();
        }

       

    }
}
