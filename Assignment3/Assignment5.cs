﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Assignment5
    {
        private int BookNo;
        private string Booktitle;
        private float Price;
        private float Total_cost;
        public int number_copies = 0;



        public void input(int BookNo, string Booktitle, float Price)
        {
            this.BookNo = BookNo;
            this.Booktitle = Booktitle;
            this.Price = Price;
        }

        public void Purchased()
        {
            Console.WriteLine("Input the number of copies to be purchased:");
            number_copies = Convert.ToInt32(Console.ReadLine());
        }
        public float Total_Cost()
        {
            return Total_cost = number_copies * Price;
        }
        static void Main(string[] args)
        {
            Assignment5 obj = new Assignment5();
            Console.WriteLine("Book No:");
            int BookNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Book Title:");
            string Booktitle = Console.ReadLine();
            Console.WriteLine("Book Price:");
            float Price = Convert.ToSingle(Console.ReadLine());
            obj.input(BookNo, Booktitle, Price);
            obj.Purchased();
            obj.Total_Cost();
            Console.WriteLine("Total cost: {0}", obj.Total_Cost());
            Console.ReadLine();
        }
    }
    }

