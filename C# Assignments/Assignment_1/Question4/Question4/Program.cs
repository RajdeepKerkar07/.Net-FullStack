using System;

namespace Question4
{
    class Program
    {
        public static void swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter 2 Numbers: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before swapping: a={a}, b={b}");
            swap(ref a, ref b);
            Console.WriteLine($"After swapping: a={a}, b={b}");

        }
    }
}
