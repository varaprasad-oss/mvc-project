using System;

namespace nov15
{
    class Program:IClass1,IClass2
    {
        static void Main(string[] args)
        {
            var c = (int)MyEnum.friday;
            Console.WriteLine("friday value is :"+c);
            //Program p = new Program();
            //p.add(5, 5);
            //p.mul(4, 8);
            //p.sub(3, 5);
            //p.display();
            //p.age();
            //p.add(5, 6);

        }

        public void add(int a, int b)
        {

            Console.WriteLine("addition of two umbers is:" + (a + b));
        }

        public void age()
        {

            Console.WriteLine("my age is 39");
        }

        public void display()
        {
            Console.WriteLine("My name is rama krishna vara prasad");
        }

        public void mul(int a, int b)
        {
            Console.WriteLine(  a*b);
        }

        public void sub(int a, int b)
        {

            Console.WriteLine(a-b);
        }

        int IClass1.add(int a, int b)
        {
            throw new NotImplementedException();
        }

        int IClass1.mul(int a, int b)
        {
            throw new NotImplementedException();
        }

        int IClass1.sub(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
