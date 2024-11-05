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
        public bool IsCheckedOut { get; set; }
    }

    class Program
    {
        //TODO: add method for adding and removing books through passing parametres into the methods.
        static void Main(string[] args)
        {
            List<Book> Library = new List<Book>();
            Library.Add(new Book { Title = "1984", Author = "George Orwell", Year = 1949, IsCheckedOut = false });
            Library.Add(new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960, IsCheckedOut = true });
            Library.Add(new Book { Title = "Pride and Prejudice", Author = "Jane Austen", Year = 1813, IsCheckedOut = false });
            Library.Add(new Book { Title = "Moby Dick", Author = "Herman Melville", Year = 1851, IsCheckedOut = false });
            Library.Add(new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925, IsCheckedOut = false });
            Library.Add(new Book { Title = "Treasure Island", Author = "Robert Louis Stevenson", Year = 1883, IsCheckedOut = true });
            Library.Add(new Book { Title = "Fahrenheit 451", Author = "Ray Bradbury", Year = 1953, IsCheckedOut = false });
            Library.Add(new Book { Title = "The Wolf of Wall Street", Author = "Jordan Belfort", Year = 2007, IsCheckedOut = false });
            Library.Add(new Book { Title = "The Sound and the Fury", Author = "William Faulkner", Year = 1929, IsCheckedOut = true });
            Library.Add(new Book { Title = "The Catcher in the Rye", Author = "J.D. Salinger", Year = 1951, IsCheckedOut = true });

            
            
            void BorrowByName(string bookBorrow)
            {
               foreach (var title in Library)
                {
                    if (title.Title == bookBorrow )
                    {
                        if (title.IsCheckedOut == true) 
                                {
                                     Console.WriteLine("We do not have this book in stock right now");
                                } else { 
                                             Console.WriteLine($"You have succesfully borrowed {bookBorrow}");
                                             break;  
                        }   
                        
                    }
                }
            }

            void ViewBooks()
            {
                foreach (var book in Library)
                {
                    Console.WriteLine($"{book.Title} by {book.Author} ({book.Year})");
                }
            };

            Console.WriteLine("Please write \"See library\" to view all books\nIf you want to borrow a book please write \"Borrow\"");
            string UserInput = Console.ReadLine();

            //TODO: fix "Unknown command. Try again after borrowing a book"
            if (UserInput == "Borrow" || UserInput == "borrow")
            {
                   Console.WriteLine("Which book would you like to borrow?");
                   string BookBorrow = Console.ReadLine();
                   BorrowByName(BookBorrow);
                   
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
