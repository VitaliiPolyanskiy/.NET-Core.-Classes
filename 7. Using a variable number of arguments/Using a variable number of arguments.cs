using System;

namespace CSharp.Params
{
    class ParamsDemo
    {
        public static int MinVal(params int[] nums)
        {
            int m;
            if (nums.Length == 0)
            {
                Console.WriteLine("Error: No arguments.");
                return 0;
            }
            m = nums[0];
            for (int i = 1; i < nums.Length; i++)
                if (nums[i] < m) m = nums[i];
            return m;

        }
        public static void ShowArgs(string msg, params int[] nums)
        {
            Console.Write(msg + ": ");
            foreach (int i in nums)
                Console.Write(i + " ");
            Console.WriteLine();
        }
        public static void Main()
        {
            int min;
            int a = 10, b = 20;
            min = MinVal(a, b);
            Console.WriteLine("The minimum is equal to " + min);
            min = MinVal(a, b, -1);
            Console.WriteLine("The minimum is equal to " + min);
            min = MinVal(18, 23, 3, 14, 'A');
            Console.WriteLine("The minimum is equal to " + min);
            int[] args = { 45, 67, 34, 9, 112, 8 };
            min = MinVal(args);
            Console.WriteLine("The minimum is equal to " + min);

            ShowArgs("Here are some integers", 1, 2, 3, 4, 5);
            ShowArgs("Here are two more numbers", 17, 20);
        }
    }
}
