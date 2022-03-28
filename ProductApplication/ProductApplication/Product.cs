using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApplication
{
    abstract class Product
    {
        public int Id;
        public string Name;
        public double Price;
        public int Count;
        public double TotalInCome;
        public static int Counter;

        public Product(string name,double price,int count,double totalInCome)
        {
            Counter++;
            Id = Counter;
            Name = name;
            Price = price;
            Count = count;
            TotalInCome = totalInCome;
        }

        public abstract void Sell();

        public abstract string ShowInfo();

    }
}
