using System;
using System.Collections.Generic;
using System.Text;

namespace practice
{
    class Encapsulat
    {
        private string name;
        private int age;
        public string StudentName { 
            get 
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int  Studentage
        {
            get
            {
                return age;

            }
            set
            {
                age = value;
            }
        }

    }
}
