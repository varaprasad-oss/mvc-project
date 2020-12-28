using System;

namespace practice
{
    class Program:Encap,IExample
    {


        private int emp;
        private int salary;

        public int EmpId
        {
            get { return emp; }
            set { emp = value; }
        }
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }

        }

        static void Main(string[] args)
        {
            Program program = new Program();
          
            program.add(3, 4);
            program.Display();
           


            //Over over = new Over();
            //over.Display();
            //Console.WriteLine(  over.Print(10, 20));
            

            ////OverLoad o = new OverLoad();
            //OverLoad.Calculate(3, 5);
            //OverLoad.Calculate(3, 45, 5);

            //Program program = new Program();
            //program.Add(4, 6);
            //Console.WriteLine( program.Name = "rsgf");
            //program.Display();            
            //Encapsulat encapsulat = new Encapsulat();

            ////Console.WriteLine(encapsulat.Studentage = 48);

            ////Console.WriteLine( encapsulat.StudentName = "rafasdd");



        }

        public void add(int a, int b)
        {
            Console.WriteLine((a+b));
        }

        public new void Display()
        {
            Console.WriteLine("implementing the interface");
            
        }

       
    }
}
