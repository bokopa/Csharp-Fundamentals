using System;
using System.Numerics;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> myBook = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                Book book = new Book();
                book.Title = input[0];
                book.Autor = input[1];
                book.Publisher = input[2];
                book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.ISBN =  input[4];
                book.Price = double.Parse(input[5]);
                myBook.Add(book);
            }
            Library myLabrary = new Library();
            myLabrary.Books = myBook;

            foreach (var book in myLabrary.Books.GroupBy(x => x.Autor)
                .OrderByDescending(x => x.Sum(y=>y.Price)).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{book.Key} -> {book.Sum(x=> x.Price):F2}");
            }
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Autor { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
               
    }
    class Library
    {

        public List<Book> Books { get; set; }
        public String Name { get; set; }

    }
}
