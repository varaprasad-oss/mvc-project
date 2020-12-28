using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleApp5
{
    class DbContextClass1:DbContext
    {
        static string connect = string.Empty;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            connect = "Data Source=192.168.50.95;Initial Catalog=vgudipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            optionsBuilder.UseSqlServer(connect);
        }
        //entites
        public DbSet<Employe1> Employees1 { get; set; }
        public DbSet<Employe2> Eemployee2 { get; set; }








    }
    
}
