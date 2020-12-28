using System;
using System.Data.SqlClient;
using System.Text;
using System.Collections.Generic;
using System.Data;

namespace adonetdec14
{
     class Program
    {
        public  static SqlConnection conn;
        static void Main(string[] args)
        {

            string str = "Data Source=192.168.50.95;Initial Catalog=vgudipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
             conn = new SqlConnection(str);
            //creatingdatatable
            CreatingTableUsingDatatableClass2 creatingTable = new CreatingTableUsingDatatableClass2();
            creatingTable.CreateTable();
                            
            /// update the records in the table 
            //UpdateRecordsClass2 updateRecords = new UpdateRecordsClass2();
            //updateRecords.UpdateRecords();
            ///creating table using the ado.net 
            //CreateTableClass2 objTable = new CreateTableClass2();
            //objTable.ScalarMethod(4);
            ////objTable.FilterBy();
            ////objTable.ReadById();


            ////objTable.DisplayRetrive();
            //objTable.Display();
            ///dispalying two tables using the data set 
            //SetOfDataClass1 obj = new SetOfDataClass1();
            //obj.DataOfSet();
            ///Displaying the two tables using the stored procedure

            //ListWithReaderWithMultipleResults obj = new ListWithReaderWithMultipleResults();
            //obj.Display();
            ///dispalying single table using the stored procedure
            //DisplayingOneTableClass1 objOnetable = new DisplayingOneTableClass1();
            //objOnetable.DisplaySingleTable();


            ///transcastion in program
            //TranscstionClass1 transcstionClass1 = new TranscstionClass1();
            //transcstionClass1.TranscationExample();

            //EmployeeClass1 employeeClass1 = new EmployeeClass1();
            //employeeClass1.Inserting();
            ///insert records using the stored procedure 
            //StoredProcdureClass1 storedProcdureClass1 = new StoredProcdureClass1();
            ////storedProcdureClass1.StoreProcess();
            //storedProcdureClass1.StoreProcess1(449, "mounika");


            //InsertRecords insertObj = new InsertRecords();
            //insertObj.Connect();
            ///inserting the records into table
            //Show();

        }

        private static void Show()
        {
            var conn = "Data Source=192.168.50.95;Initial Catalog=vgudipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                using(SqlCommand cmd=new SqlCommand("show",connection))
                {
                    SqlParameter[] prm = new SqlParameter[3];
                    prm[0] = new SqlParameter("@id", SqlDbType.Int);
                    prm[0].Value = 100;
                    prm[1] = new SqlParameter("@pin", SqlDbType.Int);
                    prm[1].Value = 25252;
                    prm[2] = new SqlParameter("@accname", SqlDbType.VarChar, 50);
                    prm[2].Value = "fgffgf";
                    cmd.Parameters.AddRange(prm);
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                }


                
        }
        }

        static  void InsertRecord()
        {
            Console.WriteLine("Enter The employee name ");
            var empName = string.Empty;
            Console.WriteLine("Enter phone number");
            var empPhoneNumber = int.Parse(Console.ReadLine());
            

        }

        private static void List()
        {
            string str = "Data Source=192.168.50.95;Initial Catalog=vgudipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            SqlConnection conn = new SqlConnection(str);
            ///Displaying the two tables using the stored procedure 
            ///
            
            
//            using(SqlConnection sc=new SqlConnection(str))

//            {
//                using(SqlCommand cmd=new SqlCommand("InsertDepartmentSubject",sc))
//                {
//                    SqlParameter[] prms = new SqlParameter[6];
//                    prms[0] = new SqlParameter("@id", SqlDbType.Int, 50);
//                    prms[0].Value = 232;
                    
//                    prms[1] = new SqlParameter("@pin", SqlDbType.Int);
//                    prms[1].Value = 454;

//                    prms[2] = new SqlParameter("@departmentName", SqlDbType.VarChar,50);
//                    prms[2].Value = "ramakrishna";

//                    prms[3] = new SqlParameter("@id1", SqlDbType.Int,50);
//                    prms[3].Value = 453;

//                    //prms[4] = new SqlParameter("@id2",SqlDbType.Int,50);
//                    //prms[4].Value = "phone";
//;
                    //prms[4] = new SqlParameter("@customerorder",SqlDbType.VarChar,50);
                    //prms[4].Value =448;

                    //prms[5] = new SqlParameter("@id2", SqlDbType.Int, 50);
                    //prms[5].Value = "phone";

                    //cmd.Parameters.AddRange(prms);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //sc.Open();
                    //cmd.ExecuteNonQuery();
                    //sc.Close();


                }
            }
            
            
            
            
            
            
            
            
            
            //SqlConnection conn = new SqlConnection(str);
            //var sql = "InsertDepartmentSubject";
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //DataTable d = new DataTable();
            //conn.Open();
            //CommandType c = CommandType.StoredProcedure;
            
            //adp.Fill(d);
            //adp.Dispose();
            //cmd.Dispose();
            //conn.Close();
            //foreach (DataRow r in d.Rows)
            //{
            //    Console.WriteLine(r["EmpName"]+ " "+r["EmpPhoneNumber"]);

            //}
            //d.Dispose();
                
        }
    

