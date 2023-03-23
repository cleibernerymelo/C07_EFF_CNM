using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E01_EF6_CF_BooksDB_DAL.Model
{
    public partial class Book
    {
        public void CreateBook()
        {
            var db = new BookContext();

            using (db)
            {
                IList<Book> books = new List<Book>
                {
                    new Book {PublisherID = 1, ISBN = "1A", Title = "Book1", Date = new DateTime(2023,03,22)},
                    new Book {PublisherID = 2, ISBN = "2B", Title = "Book2", Date = new DateTime(2023,03,22)},
                    new Book {PublisherID = 1, ISBN = "3C", Title = "Book3", Date = new DateTime(2023,03,22)}
                };

                db.Book.AddRange(books);
                db.SaveChanges();
            }
        }

        public void ReadBook()
        {
            var db = new BookContext();
            var queryBook = db.Book.Select(b => b).OrderBy(b => b.BookID);

            Utility.WriteTitle("Book");

            queryBook.ToList().ForEach(b => Console.WriteLine($"{b.BookID} - {b.Title}"));
        }
    }
}
