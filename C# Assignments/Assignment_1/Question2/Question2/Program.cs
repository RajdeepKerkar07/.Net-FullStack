using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        //2nd code
        double[] marks = new double[5];
        double max;
        Console.WriteLine("Enter marks of 5 sudents:");
        for (int i = 0; i < marks.Length; i++)
        {
            marks[i] = Convert.ToDouble(Console.ReadLine());
        }
        max = marks[0];
        for (int i = 0; i < marks.Length; i++)
        {
            if (marks[0] < marks[i])
            {
                max = marks[i];
            }
        }
        Console.WriteLine($"Highest marks: {max}");
    }
}