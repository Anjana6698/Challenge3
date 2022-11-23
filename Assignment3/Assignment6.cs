using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Assignment6
    {
        int id;
        string name;
        int[] mark = new int[3];
        int total;
        public void read()
        {
            Console.WriteLine("Enter id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter marks of 3 subjects");
            for (int i = 0; i < 3; i++)
            {
                mark[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void calculate()
        {
            total = mark[0] + mark[1] + mark[2];
        }
        public void display()
        {
            Console.WriteLine("Id={0}\nName={1}\nTotal={2}", id, name, total);
        }
    }
    class Assignment_6
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number of students");
            n = Convert.ToInt32(Console.ReadLine());
            Assignment6[] s = new Assignment6[n];
            for (int i = 0; i < n; i++)
            {
                s[i] = new Assignment6();
                s[i].read();
                s[i].calculate();
                s[i].display();
            }
            Console.ReadLine();
        }
    }
    }

