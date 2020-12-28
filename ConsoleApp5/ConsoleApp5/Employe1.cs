using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp5
{
    class Employe1
    {
        [Key]
        public int EmpId { get; set; }
       [ DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string   EmpName { get; set; }
        public string  Phonenumberr { get; set; }
        public string Location { get; set; }
       
    }
}
