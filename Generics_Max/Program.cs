using System;

namespace Generics_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Problem!");
            Console.WriteLine("Enter 3 integer numbers one by one");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Find_Max.FindMaxValue(a, b, c);
        }
    }
}