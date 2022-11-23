using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Assignment4
    {
        private int[] stack = new int[4];
        private int top = -1;

        public void Push(int value)
        {
            Console.WriteLine("Push");
            top++;
            stack[top] = value;
        }

        public int Pop()
        {
            Console.WriteLine("Pop");
            int value = stack[top];
            top--;
            return value;
        }

        public int Peek()
        {
            Console.WriteLine("Peek");
            return stack[top];
        }

        public void Display()
        {
            Console.WriteLine();
            foreach (var i in stack)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Assignment4 assignment = new Assignment4();
            assignment.Push(30);
            assignment.Push(40);
            assignment.Push(50);
            assignment.Push(60);
            assignment.Display();
            int value = assignment.Pop();
            Console.WriteLine(value);
            value = assignment.Peek();
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
