using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringLibraryTest.Task2.Models;

namespace StringLibraryTest.Task2
{
    internal class Library
    {
        private List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public List<Book> ListBooksByAuthor(string author)
        {
            List<Book> sortedBooks = new List<Book>();
            for(int i = 0; i < books.Count; i++)
            {
                if(books[i].Author.ToLower() == author.ToLower())
                    sortedBooks.Add(books[i]);
            }
            if (sortedBooks.Count == 0)
                Console.WriteLine("Книг не найдено");
            return sortedBooks;
        }
    }
}
