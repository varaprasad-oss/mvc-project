using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace adonetdec14
{
    
    class CreatingTableUsingDatatableClass2
    {
        private string connect;
        public void CreateTable()
        {
            connect = "Data Source=192.168.50.95;Initial Catalog=vgudipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            SqlConnection connection = new SqlConnection(connect);
            connection.Open();

            DataTable table = new DataTable("Table created suceesfully ");
            /// seting the autoid

            DataColumn autoid = new DataColumn("AutoId", typeof(Int32));
            autoid.AutoIncrement = true;
            autoid.AutoIncrementSeed = 2;
            autoid.ReadOnly = true;
            table.Columns.Add(autoid);


            DataColumn id = new DataColumn("Id", typeof(int));
            //id.Unique = true;
            table.Columns.Add(id);
            DataColumn name = new DataColumn("Name", typeof(string));
            table.Columns.Add(name);
            DataColumn gender = new DataColumn("Gender", typeof(char));
            table.Columns.Add(gender);

          
           
            table.Rows.Add(1,1, "rama", "m");
            table.Rows.Add(2, "vijay", "m");
            table.Rows.Add(3, "mounika", "F");
            table.Rows.Add(4, "Teja", "m");
            table.Rows.Add(5, "prasad", "m");
            table.Rows.Add(6, "anusha", "f");
            table.Rows.Add(7, "divya", "f");
            connection.Close();

            //chanding the records in the data table 
            // table.Rows[1]["Id"] = 4;
            //table.Rows[1]["Name"] = "Ramya";
            //table.Rows[1]["Gender"] = "F";
            //table.AcceptChanges();
            //table.Rows[0].Delete();
            //table.AcceptChanges();//Console.WriteLine("Printing the data table data ");

            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine($"autoid:{row[0]}   id:{row[1]}     Name:{row[1]}    Gender:{row[2]}");

            }





            //DataRow[] rowse = table.Select("id>3");
            //Console.WriteLine("printing the rows based on the id value");
            //foreach (DataRow r in rowse)
            //{
            //    table.Rows.Add(r.ItemArray);

            //}
            ////aggregate function 
            //DataRow[] aggregate = table.Select("Id=max(Id)");
            //string str = "MaxAutoID: " + aggregate[0]["Id"].ToString();
            //Console.WriteLine($"{str}");
            //DataView dataview = new DataView(table);
            //dataview.Sort = "Name desc Gender  ascending";



            //DataRow[] rk = table.Select( "Id >5");
            //foreach (DataRow r in rk)
            //{
            //    table.Rows.Add(r.ItemArray);

            //}







        }

    }
}