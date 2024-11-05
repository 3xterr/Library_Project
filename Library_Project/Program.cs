using System;
using System.Linq;
using System.Collections.Generic;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_Project
{

    class Book
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Author { get; set; }
        public bool IsChekedOut { get; set; }
    }

    class Program
    {
        //TODO: add method for adding and removing books through passing parametres into the methods.
        static void Main(string[] args)
        {
            List<Book> Library = new List<Book>();
            Library.Add(new Book { Title = "1984", Author = "George Orwell", Year = 1949, IsChekedOut = false });
            Library.Add(new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960, IsChekedOut = true });
            Library.Add(new Book { Title = "Pride and Prejudice", Author = "Jane Austen", Year = 1813, IsChekedOut = false });
            Library.Add(new Book { Title = "Moby Dick", Author = "Herman Melville", Year = 1851, IsChekedOut = false });
            Library.Add(new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925, IsChekedOut = false });
            Library.Add(new Book { Title = "Treasure Island", Author = "Robert Louis Stevenson", Year = 1883, IsChekedOut = true });
            Library.Add(new Book { Title = "Fahrenheit 451", Author = "Ray Bradbury", Year = 1953, IsChekedOut = false });
            Library.Add(new Book { Title = "The Wolf of Wall Street", Author = "Jordan Belfort", Year = 2007, IsChekedOut = false });
            Library.Add(new Book { Title = "The Sound and the Fury", Author = "William Faulkner", Year = 1929, IsChekedOut = true });
            Library.Add(new Book { Title = "The Catcher in the Rye", Author = "J.D. Salinger", Year = 1951, IsChekedOut = true });


            void ViewBooks()
            {
                foreach (var book in Library)
                {
                    Console.WriteLine($"{book.Title} by {book.Author} ({book.Year})");
                }
            };

            Console.WriteLine("Please write \"See library\" to view all books\nIf you want to borrow a book please write \"Borrow\"");
            string UserInput = Console.ReadLine();
            
            //TODO: add functionality to borrow books
            if (UserInput == "Borrow" || UserInput == "borrow")
            {
                   Console.WriteLine("Which book would you like to borrow?");
                   string BookBorrow = Console.ReadLine();
            }

            if (UserInput == "See library" || UserInput == "see library")
            {
                ViewBooks();
            }
            else
            {
                Console.WriteLine("Unknown command. Try again.");
            }
        }
    }
}
