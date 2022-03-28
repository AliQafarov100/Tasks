using System;

namespace ProductApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Martin Eden",23.50, 10, 0, "Jack London", 400);
            Book book2 = new Book("American Tragedy", 25.99, 20, 0, "Theodore Draiser", 945);
            Book book3 = new Book("White teeth", 10.99, 50, 0, "Jack London", 501);
            book.Sell();
            book.Sell();
            book2.Sell();
            book2.Sell();
            book3.Sell();
            book3.Sell();
            Console.WriteLine(book.ShowInfo());
            Console.WriteLine("~~~~~~~~~~~~");
            Console.WriteLine(book2.ShowInfo());
            Console.WriteLine("~~~~~~~~~~~~");
            Console.WriteLine(book3.ShowInfo());
        }
    }
}
