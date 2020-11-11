using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    // Use singleton solution for having one BookLibrary instance
    class BookLibrary
    {
        private static BookLibrary _instance;
        List<Book> books;

        private BookLibrary() {
            books = new List<Book>();
        }

        public static BookLibrary GetInstance()
        {
            if (_instance == null)
            {
                _instance = new BookLibrary();
            }
            return _instance;
        }

        public Book getBookByISBN(string isbn)
        {
            return books.Find(book => book.ISBN == isbn);
        }
        public Book[] getBooksByAuthor(string author)
        {
            return books.FindAll(book => book.Author == author).ToArray();
        }
        public Book[] getBooksByTitle(string title)
        {
            return books.FindAll(book => book.Title == title).ToArray();
        }
        public Book[] getBooksByPrice(double price)
        {
            return books.FindAll(book => book.Price == price).ToArray();
        }

        public Boolean isBookInColection(Book book)
        {
            return books.FindIndex(_book => _book == book) != -1;
        }

        public void AddBook(Book book)
        {
            if(getBookByISBN(book.ISBN) != null)
            {
                throw new System.ArgumentException("Duplicated ISBN");
            }
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public void ShowAllBooks()
        {
            foreach(Book book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
