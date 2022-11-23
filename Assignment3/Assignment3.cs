using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Assignment3
    {
        public static int SpaceCount(string str)
        {
            int sum = 0;
            string str1;
            for (int i = 0; i < str.Length; i++)
            {
                str1 = str.Substring(i, 1);
                if (str1 == " ")
                {
                    sum = sum + 1;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            string str2;
            Console.WriteLine("Enter a String:");
            str2 = Console.ReadLine();
            Console.WriteLine("This string contains {0} spaces", SpaceCount(str2));
            Console.ReadLine();
        }
    }
}
