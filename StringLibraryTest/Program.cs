using StringLibraryTest.Task1;
using StringLibraryTest.Task2;
using StringLibraryTest.Task2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLibraryTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
        }
        private static void FirstTask()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(baseDir, @"..\..\Data\input.txt");
            MaxLengthString task1 = new MaxLengthString();
            string maxString = task1.GetMaxString(path);
            List<string> invWords = task1.ListInvalidWords(path);

            Console.WriteLine("Слово наибольшей длины:   " + maxString);
            Console.WriteLine("Перечень плохих слов:    ");
            foreach (string word in invWords)
            {
                Console.Write(word + ", ");
            }
            Console.WriteLine();
        }
        private static void SecondTask()
        {
            Library library = new Library();
            library.AddBook(new Book("Преступление и наказание", "Достоевский", 1866));
            library.AddBook(new Book("Белые ночи", "Достоевский", 1848));
            library.AddBook(new Book("Бесы", "Достоевский", 1872));
            library.AddBook(new Book("Капитанская дочка", "Пушкин", 1834));

            Console.Write("Введите имя автора (для проверки есть Достоевский и Пушкин): ");
            string author = Console.ReadLine();
            List<Book> books = library.ListBooksByAuthor(author);
            foreach (Book book in books)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
