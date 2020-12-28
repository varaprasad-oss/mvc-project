using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace linkdec16
{
    
    class Program
    {
         static  string _connect;
        static void Main(string[] args)
        {
            _connect = "Data Source=192.168.50.95;Initial Catalog=vgudipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";


            var employees = GetEmployees();
            //var data = employees.Where(d => d.EmpId.Equals(1));
            //var data = employees.Where(d => d.Department.StartsWith("h"));
            var data = employees.Where(d => d.EmpSalary > 30000);
            

            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item.EmpId + " " + item.EmpSalary + " " + item.Department);
            //}
            foreach (var item in data)
            {
                Console.WriteLine( $"employee id:{item.EmpId} employee salary : {item.EmpSalary}  employee department :{item.Department}");

            }

        }
        private static IList<LinqExample> GetEmployees()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connect))
            {
                var sql = "SELECT * FROM Employees2";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(command))
                    {
                        ad.Fill(dataTable);
                    }
                }
            }

            IList<LinqExample> employees = new List<LinqExample>();
            foreach (DataRow row in dataTable.Rows)
            {
                var employee = new LinqExample()
                {

                    EmpId = int.Parse(row["empid"].ToString()),
                    EmpSalary = decimal.Parse(row["empSalary"].ToString()),
                    Department=row["department"].ToString()

                };
                employees.Add(employee);
            }

            return employees;
        }


    }
}
