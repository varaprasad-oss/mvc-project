using System;
using System.Configuration;
using System.Data.SqlClient;

namespace adonetdec
{
    class Program
    {
    

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static void List()
        {
            Console.WriteLine("enter employee's department number you want to fetch");
            var dep = Console.ReadLine();
            string _connStr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
        }
    }
}
