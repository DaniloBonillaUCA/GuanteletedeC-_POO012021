using System;

namespace example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;

            Console.WriteLine("Enter a value for a:");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for b:");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Resting {a} - {b} equals {RestNumbers(a,b)}");
        }
        public static int RestNumbers(int a, int b)
        {
            return a - b;
        }
    }
    
}
