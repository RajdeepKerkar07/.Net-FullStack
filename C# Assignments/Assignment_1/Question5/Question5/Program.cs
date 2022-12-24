using System;

namespace Question5
{
    class Program
    {

        public static void cal(double r, ref double ar, ref double cir)
        {
            ar = 3.14 * r * r;
            cir = 2 * 3.14 * r;
        }

        static void Main(string[] args)
        {
            double ar = 0, cir = 0;
            Console.WriteLine("Enter the radius: ");
            double r = Convert.ToDouble(Console.ReadLine());
            cal(r, ref ar, ref cir);
            Console.WriteLine($"Area = {ar} square units, Circumference = {cir} units");
        }
    }
}
