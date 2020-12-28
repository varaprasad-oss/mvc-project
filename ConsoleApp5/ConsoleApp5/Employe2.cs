using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp5
{
    
    public class Employe2
    {
        [Key]
        public int EmpId { get; set; }


        public string EmpSalary { get; set; }

        public string department { get; set; }

        

       

       
    }
}
