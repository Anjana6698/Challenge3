using System;

namespace Assignment3
{
    class Program
    {
        public class student
        {
            private string name;
            private int id;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int Id
            {
                get { return id; }
                set { id = value; }
            }



            public void displaydetails()
            {
                Console.WriteLine("Name:" + name);
                Console.WriteLine("Id:" + id);
            }
        }

        static void Main(string[] args)
        {
            student obj = new student();
            obj.Name = "Anjana";
            obj.Id = 20;
            obj.displaydetails();
            Console.WriteLine("\n press Enter key to exit....");
            Console.ReadLine();
        }
    }
}
