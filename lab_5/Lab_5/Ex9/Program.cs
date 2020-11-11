using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Program
    {
        static int booksNo = 10;
        static Random random;
        static string[] authors = new string[] { "Alan", "Arthur", "Andrzej", "Andrew" };
        static string[] titles = new string[] { "Adventures", "Horror", "Thriller", "Science", "Fun" };
        static void Main(string[] args)
        {
            random = new Random(2131421412);

            Book a = generateBook();
            BookLibrary bookLibrary = BookLibrary.GetInstance();

            bookLibrary.AddBook(a);
            try 
            {
                bookLibrary.AddBook(a);
            }
            catch (System.ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Is book in library: {0}", bookLibrary.isBookInColection(a));
            // Index starts at 1, because book a is already in the library
            for(int i=1; i<booksNo; i++)
            {
                bookLibrary.AddBook(generateBook());
            }

            Console.WriteLine("------------------");
            Console.WriteLine("All books");
            bookLibrary.ShowAllBooks();
            Console.WriteLine("------------------");

            showAllByAuthor(0);

            Console.ReadLine();
        }

        static void showAllByAuthor(int authorIndex)
        {
            BookLibrary bookLibrary = BookLibrary.GetInstance();
            Book[] books = bookLibrary.getBooksByAuthor(authors[authorIndex]);

            Console.WriteLine("------------------");
            Console.WriteLine("Books by: {0}", authors[authorIndex]);
            foreach(Book book in books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("------------------");
        }

        static Book generateBook()
        {
            Book book = new Book(RandomString(20));
            book.Author = authors[random.Next(0, authors.Length)];
            book.Title = titles[random.Next(0, titles.Length)];
            book.Price = Math.Round(random.NextDouble() * 20, 2);
            book.Date = RandomDay();

            return book;
        }
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(range));
        }
    }

}
