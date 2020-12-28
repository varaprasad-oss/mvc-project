using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        private  static string connect;
        static void Main(string[] args)
        {
            connect =  "Data Source=192.168.50.95;Initial Catalog=vgudipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            var listName = GetList();
            //foreach (var i in listName)
            //{
            //    Console.WriteLine($"{i.EmpId}  {i.EmpLocation}   {i.EmpGender}  {i.EmpName} {i.EmpPhoneNUmber}   {i.EmpSalary}  {i.AutioId}");

            //}
            //for (int i = 0; i < listName.Count; i++)
            //{
            //    Console.WriteLine($"{listName[i].EmpLocation}   {listName[i].EmpGender} {listName[i].EmpId}  {listName[i].EmpName}  {listName[i].EmpPhoneNUmber}   {listName[i].EmpSalary}");

            //}
            var data = listName.Where(d => d.EmpLocation.StartsWith("H"));
            //var data = listName.Where(d => d.EmpName.StartsWith("R"));
            var avg = listName.Average(d => d.EmpSalary);
            
            var totalSalary = listName.Sum(d => d.EmpSalary);
            var salary = listName.Where(d => d.EmpSalary > 35000);
            foreach (var item in salary)
            {
                Console.WriteLine($"{item.EmpId}  {item.EmpSalary}");

            }
            //Console.WriteLine($"The total employees salary is{totalSalary}");
            //var concating = listName.Concat(d=>d.);
            //Console.WriteLine($"The average salary of employee is {data}");
            //contains 
            //var containg = listName.objClass.EmpLocation.Contains("HYD");
            var cont = from TollplusTrainees11_dec in listName
                       where TollplusTrainees11_dec.EmpLocation.Contains("HYD")
                       select TollplusTrainees11_dec;

            //var cat = data.Concat(cont);
            //foreach (var item in cat)
            //{
            //    Console.WriteLine(item.EmpId+ "" +item.EmpName+ " " +item.EmpGender+ "" +item.EmpLocation);
            //}
            //var reverseing = cont.Reverse();
            //Console.WriteLine($"Reversing the  concatenated string {reverseing}");
            //var concating = from TollplusTrainees11_dec in listName
            //                where TollplusTrainees11_dec.EmpName.Concat()
            //                select TollplusTrainees11_dec;

            ///starts with method
            var data1 = from TollplusTrainees11_dec in listName
                        where TollplusTrainees11_dec.EmpName.StartsWith("R")
                        select TollplusTrainees11_dec;
            ///contains method
            var conta= from TollplusTrainees11_dec in listName
                       where TollplusTrainees11_dec.EmpLocation.Contains("HYD")
                       select TollplusTrainees11_dec;


            //foreach (var i in cont)
            //{
            //    Console.WriteLine($"{i.EmpId}  {i.EmpLocation}   {i.EmpGender}  {i.EmpName} {i.EmpPhoneNUmber}   {i.EmpSalary}  {i.AutioId}");


            //}

        }
        private static IList<Class1> GetList()
        {

            var query = " SELECT * FROM TollplusTrainees11_dec ";
            DataTable dtable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connect))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    using (SqlDataAdapter adpater = new SqlDataAdapter(cmd))
                    {
                        adpater.Fill(dtable);
                    }


                }

            }



            IList<Class1> listName = new List<Class1>();
            foreach (DataRow row in dtable.Rows)
            {
                var objClass = new Class1()
                {
                    EmpId = int.Parse(row["EmpId"].ToString()),
                     
                    EmpName = row["EmpName"].ToString(),
                     
                     
                    EmpGender = row["EmpGender"].ToString(),
                   
                    EmpLocation = row["EmpLocation"].ToString(),

                     
                    EmpPhoneNUmber = int.Parse(row["EmpPhoneNumber"].ToString()),

                   
                    AutioId = int.Parse(row["AutoId"].ToString()),

                };
                if (row["EmpSalary"]!=DBNull.Value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          ) 
                {
                    objClass.EmpSalary = decimal.Parse(row["EmpSalary"].ToString());
                }

                listName.Add(objClass);

            }
            return listName;
        }


        
    }
}
