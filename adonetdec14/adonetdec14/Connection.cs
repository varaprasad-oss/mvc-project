using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace adonetdec14
{
     public class Connection
    {
        private string connectionString;
        private SqlConnection sconnect;
        public void Connect()
        {
            connectionString = "Data Source=192.168.50.95;Initial Catalog=vgudipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
             sconnect = new SqlConnection(connectionString);
            sconnect.Open();
            if (sconnect.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("The sql connected sueccsfully ");
            }
            sconnect.Close();


        }
    }
}
