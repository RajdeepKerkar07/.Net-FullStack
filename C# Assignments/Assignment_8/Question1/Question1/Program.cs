using System;
using System.Reflection;

namespace Question1
{
    public class Example
    {
        public int add(string a, string b)
        {
            int res = Convert.ToInt32(a) + Convert.ToInt32(b);
            return res;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            Type exampleType = executingAssembly.GetType("Question1.Example");

            object exampleInstance = Activator.CreateInstance(exampleType);

            MethodInfo addNum = exampleType.GetMethod("add");

            string[] parameters = new string[2];
            parameters[0] = "2";
            parameters[1] = "5";

            int res = (int)addNum.Invoke(exampleInstance, parameters);
            Console.WriteLine($"Result = {res}");
        }
    }
}
