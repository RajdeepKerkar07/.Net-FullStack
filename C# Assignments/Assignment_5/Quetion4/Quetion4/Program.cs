using System;

namespace Quetion4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> stack = new MyStack<string>();
            stack.push("hello");
            stack.push("hi");
            stack.push("hi");
            stack.push("hi");
            stack.push("hi");
            stack.push("hi");
            stack.pop();
            stack.display();
            Console.ReadKey();
        }
    }
}
