using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3Q2
{
    public class StackException : Exception{
        public StackException(string message) : base(message){}
    }
    public class MyStack : ICloneable
    {
        private int[] arr = new int[20];
        private int top = -1;
        private int size;

        public object Clone()
        {
            Console.WriteLine("----Cloned Array----");
            MyStack newStack = new MyStack
            {
                arr = this.arr,
                top = this.top,
                size = this.size
            };
            return newStack;
        }
        public int SIZE { get { return size; } set { this.size = arr.Length; } }

        public void push(int a)
        {
            if(top == arr.Length-1)
            { 
                throw new StackException("Fullstack Exception.");
            }
            arr[++top] = a;
            Console.WriteLine($"\nPushed {a} onto the stack.");
        }
        public void pop()
        {
            if (top == -1)
            {
                throw new StackException("EmptyStack Exception.");
            }
            Console.WriteLine($"\n{arr[top]} popped.");
            arr[top--] = 0;
        }
        public void display()
        {
            Console.WriteLine("\n---Printing---");
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
