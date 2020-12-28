using System;
using System.Collections.Generic;

namespace nov16
{

    public class emp
    {
        static void Main() 
        { 
        
            void emplo()

            {

                List<PersonalDetail> listPD = new List<PersonalDetail>();



                PersonalDetail myPd = new PersonalDetail();



                myPd.empId = int.Parse(Console.ReadLine());


                myPd.EmpName = Console.ReadLine();


                myPd.salary = 50;
                // seting the property

                listPD.Add(myPd);



                foreach (var item in listPD)

                {
                    Console.WriteLine(item.EmpName + ", " + item.empId + "," + item.salary);

                }
            }
        } 



    }
        
    
}

