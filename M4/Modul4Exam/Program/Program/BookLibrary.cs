using System.Collections.Generic;
using System.Linq;

namespace Program
{
    public class BookLibrary
    {
        private string name;
        private List<Book> books;
        public BookLibrary(string name)
        {
            this.name = name;
            this.books = new List<Book>();
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public List<Book> Books
        {
            get { return this.books; }
            set { this.books = value; }
        }
        public void AddBook(string title, double rating)
        {
            books.Add(new Book(title, rating));
        }
        public double AverageRating()
        {
            double avRating = 0;
            foreach (Book b in books)
            {
                avRating += b.Rating;
            }
            return avRating / books.Count;
        }
        public List<string> GetBooksByRating(double rating)
        {
            List<string> bestBooks = new List<string>();
            foreach (Book b in books)
            {
                if (b.Rating > rating) bestBooks.Add(b.Title);
            }
            return bestBooks;
        }
        public List<Book> SortByTitle()
        {
            books = books.OrderBy(x => x.Title).ToList();
            return books;
        }
        public List<Book> SortByRating()
        {
            books = books.OrderByDescending(x => x.Rating).ToList();
            return books;
        }
        public string[] ProvideInformationAboutAllBooks()
        {
            string[] info = new string[books.Count];
            for (int i = 0; i < books.Count; i++)
            {
                info[i] = books[i].ToString();
            }
            return info;
        }
        public bool CheckBookIsInBookLibrary(string title)
        {
            foreach (Book b in books)
            {
                if (b.Title.Equals(title)) return true;
            }
            return false;
        }
    }
}