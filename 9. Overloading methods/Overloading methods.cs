using System;
namespace Overload
{
    class Sample
    {
        public static void Test(int a)
        {
            Console.WriteLine("int");
        }
        public static void Test(short a)
        {
            Console.WriteLine("short");
        }
        public static void Test(double a)
        {
            Console.WriteLine("double");
        }
        public static void Test(ref int a)
        {
            Console.WriteLine("ref int");
        }

        /*
         * You cannot create two overloads with ref and out on the same type.
         * 
         public static void Test(out int a) 
         {
             Console.WriteLine("out int");
             a = 10;
         }
        */

        public static void Test(params int[] a)
        {
            Console.WriteLine("params");
        }

        public static void Test(int a, int b = 10, int c = 20)
        {
            Console.WriteLine("default parametr: {0}, {1}, {2} ", a, b, c);
        }
        public static void Main()
        {
            int a = 45;
            Test(a); // сигнатура с int
            Test(ref a); // ref int
            Test(2.4); // double
            short d = 1;
            Test(d); // short
            byte x = 1;
            Test(x); // short
            Test(1, 2, 3, 4); // params
            Test('A'); // int
            Test(10); // int
            Test(100, 200); // default parametr
            Test(100, 200, 300); // default parametr
        }
    }
}
