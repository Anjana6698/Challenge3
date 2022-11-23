using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Assignment8
    {
        private int StudentId;
        private string Studentname;
        public void Student_Read()
        {
            Console.WriteLine("Enter the Student Id ");
            StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Student Name ");
            Studentname = Convert.ToString(Console.ReadLine());
        }
        public void Student_display()
        {
            Console.WriteLine("Student Id " + StudentId);
            Console.WriteLine("Student Name " + Studentname);
        }

    }
    class internals : Assignment8
    {
        protected int Marks_internal;
        public void internals_Read()
        {
            Student_Read();
            Student_display();
            Console.WriteLine("Enter Marks of Internal ");
            Marks_internal = Convert.ToInt32(Console.ReadLine());
        }
        public void internals_display()
        {
            Console.WriteLine("Marks of Internal " + Marks_internal);
        }

    }
    class externals : internals
    {
        private int Marks_external;
        private int Marks_Total;
        public void externals_Read()
        {
            internals_Read();
            Console.WriteLine("Enter Marks of External ");
            Marks_external = Convert.ToInt32(Console.ReadLine());
        }
        public void externals_Calculate()
        {
            Marks_Total = Marks_internal + Marks_external;
        }
        public void externals_display()
        {
            internals_display();
            Console.WriteLine("Marks of External " + Marks_external);
            Console.WriteLine("Total Marks " + Marks_Total);
        }


    }
    internal class Assignment8_Class
    {
        static void Main(string[] args)
        {
            externals ext = new externals();
            ext.externals_Read();
            ext.externals_Calculate();
            ext.externals_display();
            Console.ReadLine();
        }
    }
}

