using System;

namespace Access_modifire
{
    public class Program
    {
        public void Test1()
        {
            Console.WriteLine("Hi I am Public Access Modifire: \n");
            //Console.ReadLine();
        }

        private void Test2()
        {
            Console.WriteLine("Hi I am Private Access Modifire: \n");
        }

        internal void Test3()
        {
            Console.WriteLine("Hi I am Internal Access Modifire: \n");
        }

        protected void Test4()
        {
            Console.WriteLine("Hi I am Protected Access Modifire: \n");
        }

        protected internal void Test5()
        {
            Console.WriteLine("Hi I am Protected internal Access Modifire: \n");
        }

        static void Main(string[] args)
        {
            //Program obj = new Program();

            //obj.Test1();
            //obj.Test2();
            //obj.Test3();
            //obj.Test4();
            //obj.Test5();


            Console.ReadLine();
        }
    }
}

