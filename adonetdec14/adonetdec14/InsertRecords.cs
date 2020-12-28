using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace adonetdec14
{
    class InsertRecords
    {
        private string connction;
        private SqlConnection sc;
        public void Connect()
        {
            connction = "Data Source=192.168.50.95;Initial Catalog=vgudipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            sc = new SqlConnection(connction);




            Console.WriteLine("enter the father name  ");
            string fatherName = Console.ReadLine();
            Console.WriteLine("enter the adhar number ");
            var status = Console.ReadLine();
            sc.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TollplusTrainessDetails11_dec(EmpFatherName,EmpStatus) VALUES(@fatherName,@status)", sc);
            //SqlCommand cmd = new SqlCommand("INSERT INTO Products(product name, productprice) VALUES(@product name,@productprice)", sc);
           cmd.Parameters.AddWithValue("@fatherName", fatherName);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.ExecuteNonQuery();
            sc.Close();

        }
    }
}
