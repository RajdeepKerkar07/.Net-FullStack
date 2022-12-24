using System;

namespace Question3
{
    class Program
    {
        public static int sum(params int[] arr)
        {
            int sum1=0;
            for(int i = 0; i<arr.Length; i++)
            {
                sum1 += arr[i];
            }
            return sum1;
        }
        static void Main(string[] args)
        {
            int result;
            result = sum(1, 2, 3, 4, 5);
            Console.WriteLine($"The sum is {result}");
        }
    }
}
