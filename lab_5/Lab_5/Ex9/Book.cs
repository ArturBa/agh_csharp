using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Book
    {
        string _title;
        string _author;
        double _price;
        readonly string _isbn;
        DateTime date;

        public Book(string isbn)
        {
            _isbn = isbn;
        }
        public string Title
        {
            get => _title;
            set => _title = value ?? throw new ArgumentNullException(nameof(Title));
        }
        public string Author
        {
            get => _author;
            set => _author = value ?? throw new ArgumentNullException(nameof(Author));
        }
        public double Price
        {
            get => _price;
            set => _price = value;
        }
        public string ISBN
        {
            get => _isbn;
        }
        public DateTime Date
        {
            get => date;
            set => date = value;
        }
        public override string ToString()
        {
            String s = String.Format("ISBN: {0}\nTitle: {1}\nAuthor: {2}\nPrice: {3}\nDate: {4}",
                         _isbn, _title, _author, _price, date);
            return s;
        }
    }
}
