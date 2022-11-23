using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Assignment7
    {
        int id;
        string name;
        int mark;
        public void read()
        {
            Console.WriteLine("Enter id:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter mark:");
            mark = int.Parse(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("{0} {1} {2}", id, name, mark);
        }
        public void swap(Assignment7 a)
        {
            int temp = id;
            id = a.id;
            a.id = temp;
            temp = mark;
            mark = a.mark;
            a.mark = temp;
            string temp1 = name;
            name = a.name;
            a.name = temp1;
        }
    }
    class Assignment_7
    {
        static void Main(string[] args)
        {
            Assignment7 s1 = new Assignment7();
            Assignment7 s2 = new Assignment7();
            s1.read();
            s2.read();
            Console.WriteLine("Before swap");
            s1.display();
            s2.display();
            Console.WriteLine("After Swap");
            s1.swap(s2);
            s1.display();
            s2.display();

            Console.ReadLine();
        }
    }
    }

