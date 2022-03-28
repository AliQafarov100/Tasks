using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApplication
{
    class Book : Product
    {
        public string AuthorName;
        public int PageCount;

        public Book(string name,double price,int count,double totalInCome,string authorName,int pageCount) : base
            (name,price,count,totalInCome)
        {
            AuthorName = authorName;
            PageCount = pageCount;
        }

        public override void Sell()
        {
            if(Count > 0)
            {
                Count--;
                TotalInCome += Price;
            }
            else
            {
                Console.WriteLine("product is complete");
            }
        }

        public override string ShowInfo()
        {
            return $" Id: {Id}\n Name: {Name}\n Price: {Price}\n Count: {Count}\n Total in Come: {TotalInCome}\n Author name: " +
                $"{AuthorName}\n Page count: {PageCount}";
        }
    }
}
