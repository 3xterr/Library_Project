using System;
using System.Linq;
using System.Collections.Generic;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_Project
{

    class Book
    {
        public int BookNumber { get; set; }
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
            Library.Add(new Book { BookNumber = 1, Title = "1984", Author = "George Orwell", Year = 1949, IsCheckedOut = false });
            Library.Add(new Book { BookNumber = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960, IsCheckedOut = true });
            Library.Add(new Book { BookNumber = 3, Title = "Pride and Prejudice", Author = "Jane Austen", Year = 1813, IsCheckedOut = false });
            Library.Add(new Book { BookNumber = 4, Title = "Moby Dick", Author = "Herman Melville", Year = 1851, IsCheckedOut = false });
            Library.Add(new Book { BookNumber = 5, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925, IsCheckedOut = false });
            Library.Add(new Book { BookNumber = 6, Title = "Treasure Island", Author = "Robert Louis Stevenson", Year = 1883, IsCheckedOut = true });
            Library.Add(new Book { BookNumber = 7, Title = "Fahrenheit 451", Author = "Ray Bradbury", Year = 1953, IsCheckedOut = false });
            Library.Add(new Book { BookNumber = 8, Title = "The Wolf of Wall Street", Author = "Jordan Belfort", Year = 2007, IsCheckedOut = false });
            Library.Add(new Book { BookNumber = 9, Title = "The Sound and the Fury", Author = "William Faulkner", Year = 1929, IsCheckedOut = true });
            Library.Add(new Book { BookNumber = 10, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Year = 1951, IsCheckedOut = true });

            void showMenu()
            {
                bool running = true;
                while (running = true)
                {
                    Console.WriteLine("=====================================");
                    Console.WriteLine("            Library Menu             ");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("1. View all books");
                    Console.WriteLine("2. Borrow a book");
                    Console.WriteLine("3. Exit");
                    Console.WriteLine("=====================================");
                    Console.Write("Please select an option: ");

                    Console.Write("Enter a command: ");
                    string command = Console.ReadLine();
                    switch (command)
                    {
                        case "1":
                            ViewBooks(); break;
                        
                        case "2":
                            Console.Write("Enter the title of the book you want to borrow: ");
                            int bookBorrow = Convert.ToInt32(Console.ReadLine());
                            BorrowByName(bookBorrow);
                            break;
                        
                        case "3":
                            running = false; 
                            Console.WriteLine("Exiting the library system. Goodbye!");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid command. Please try again.");
                            break;
                    }
                    if (running)
                    {
                        Console.WriteLine("\nType \"Back\" to return to the menu");
                        string UserInput = Console.ReadLine();
                        if (UserInput == "Back" || UserInput == "back")
                        {
                            showMenu();
                        } else { Console.WriteLine("Please try again"); }
                    } 
                }
                
            }

            showMenu();
            
            void BorrowByName(int bookBorrow)
            {
               foreach (var title in Library)
                {
                    if (title.BookNumber == bookBorrow )
                    {
                        if (title.IsCheckedOut == true) 
                        {
                                     Console.WriteLine("We do not have this book in stock right now");
                        } else { 
                                             Console.WriteLine($"You have succesfully borrowed {title.Title}");
                                             break;  
                               }   
                        
                    }
                }
            }

            void ViewBooks()
            {
                foreach (var book in Library)
                {
                    Console.WriteLine($"{book.BookNumber} - {book.Title} by {book.Author} ({book.Year})");  
                }
            };
        }
    }
}
