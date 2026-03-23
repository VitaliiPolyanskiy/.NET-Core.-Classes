using System;
using System.Text;
namespace CSharp.Classes
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            double a = 10, b = 5;
            Console.WriteLine("a = " + a + "\t b = " + b);
            NoSwap(a, b);
            Console.WriteLine("a = " + a + "\t b = " + b);
            Swap(ref a, ref b);
            Console.WriteLine("a = " + a + "\t b = " + b + "\n");

            int[] A = [1, 2, 3];
            Console.WriteLine("\nМасив A");
            foreach (int n in A)
                Console.Write("{0,4}", n);
            int[] B = [4, 5, 6];
            Console.WriteLine("\n\nМасив B");
            foreach (int n in B)
                Console.Write("{0,4}", n);

            NoSwapArray(A, B);

            Console.WriteLine("\n\nМасив A");
            foreach (int n in A)
                Console.Write("{0,4}", n);
            Console.WriteLine("\n\nМасив B");
            foreach (int n in B)
                Console.Write("{0,4}", n);

            SwapArray(ref A, ref B);

            Console.WriteLine("\n\nМасив A");
            foreach (int n in A)
                Console.Write("{0,4}", n);
            Console.WriteLine("\n\nМасив B");
            foreach (int n in B)
                Console.Write("{0,4}", n);

            string s1 = "C#", s2 = ".NET10";

            NoSwapString(s1, s2);

            Console.WriteLine("\n\nРядок 1: " + s1);
            Console.WriteLine("\nРядок 2: " + s2);

            SwapString(ref s1, ref s2);

            Console.WriteLine("\nРядок 1: " + s1);
            Console.WriteLine("\nРядок 2: " + s2);

            Calculate(a, b, out double add, out double subtract, out double mult, out double div);
            Console.WriteLine("\na = " + a + "\t b = " + b + "\n\n");
            Console.WriteLine("Сума чисел " + add);
            Console.WriteLine("Різниця чисел " + subtract);
            Console.WriteLine("Добуток чисел " + mult);
            Console.WriteLine("Ділення чисел " + div);

            Student st = new("Юрій", "Олексієнко", 20, 12);
            st.Show();
            (string firstName, string lastName, int age, double rating) = st;
            Console.WriteLine($"{firstName}\t{lastName}\t{age}\t{rating}");

            st = new Student("Дмитро", "Павленко", 24, 11);
            (string Name, string surname, _, double avg) = st;
            Console.WriteLine($"{Name}\t{surname}\t\t{avg}");
        }

        static void NoSwap(double n, double m)
        {
            double temp = n;
            n = m;
            m = temp;
        }

        static void Swap(ref double n, ref double m)
        {
            double temp = n;
            n = m;
            m = temp;
        }

        static void NoSwapString(string n, string m)
        {
            string temp = n;
            n = m;
            m = temp;
        }

        static void SwapString(ref string n, ref string m)
        {
            string temp = n;
            n = m;
            m = temp;
        }

        static void NoSwapArray(int[] a, int[] b)
        {
            a[0] = 10;
            b[0] = 40;
            int[] temp = a;
            a = b;
            b = temp;
        }

        static void SwapArray(ref int[] a, ref int[] b)
        {
            a[0] = 100;
            b[0] = 400;
            int[] temp = a;
            a = b;
            b = temp;
        }

        static void Calculate(in double n, in double m, out double add, out double subtract, out double mult, out double div)
        {
            add = n + m;
            subtract = n - m;
            mult = n * m;
            div = n / m;
        }
    }
}