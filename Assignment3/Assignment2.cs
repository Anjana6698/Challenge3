using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Assignment2
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }
    class Circle : Assignment2
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a square");
        }
    }

    class Rectangle : Assignment2
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }
    class Assignment2_Class
    {
        static void Main(string[] args)
        {
            Assignment2 shape = new Rectangle();
            shape.Draw();

            shape = new Circle();
            shape.Draw();


            Console.ReadLine();
        }
    }

   }

   