using System;
using System.Data;
using System.Data.SqlClient;


namespace adonetdec14
{
    class SetOfDataClass1
    {
        private string connectString;
        public void DataOfSet()
        {
            connectString = "Data Source=192.168.50.95;Initial Catalog=vgudipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";

            DataSet dataset = new DataSet();
            using (SqlConnection sqlConnect = new SqlConnection(connectString))
            {
                using (SqlCommand cmd = new SqlCommand("USP_MultipleTables", sqlConnect))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        // connection.Open();
                        ad.Fill(dataset);
                        // connection.Close();
                    }


                }
            }
            Console.WriteLine("*******List of students Table*******");
            Console.WriteLine("The students Table :");
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
             
                Console.WriteLine(row["name"]+"|||"+row["id"]);

            }
            Console.WriteLine("======List of Students marks===========");
            Console.WriteLine("The students marks table : ");
            foreach (DataRow row  in dataset.Tables[1].Rows )
            {
               
                Console.WriteLine(row["marks"]+"||"+row["id"]+"||"+row["rank"]+"||"+row["school_id"]);
                

            }

        }

    }
    
}
