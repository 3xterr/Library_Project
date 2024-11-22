using System;
using System.Linq;
using System.Collections.Generic;
using static System.Reflection.Metadata.BlobBuilder;
using System.Security.Authentication;

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
        //TODO: add method removing books.
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

            
            void showMenu()
            {
                bool running = true;
                while (running == true)
                {
                    Console.WriteLine("=====================================");
                    Console.WriteLine("            Library Menu             ");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("1. View all books");
                    Console.WriteLine("2. Borrow a book");
                    Console.WriteLine("3. Add a book to the library");
                    Console.WriteLine("4. Remove a book from the library");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine("=====================================");
                    Console.Write("Please select an option: ");

               
                    string command = Console.ReadLine();
                    switch (command)
                    {
                        case "1":
                            ViewBooks(); break;
                        
                        case "2":
                            Console.Write("Enter the nunber of the book you want to borrow: ");
                            int bookBorrow = Convert.ToInt32(Console.ReadLine());
                            BorrowByName(bookBorrow);
                            break;

                        case "3":
                            AddBook();
                            break;

                        case "4":
                            Console.WriteLine("Enter the number of the book that you would like to remove: ");
                            int removeBook = Convert.ToInt32(Console.ReadLine());
                            RemoveBook(removeBook);
                            break;

                        case "5":
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
                        Console.WriteLine("\nPress Enter to go back");
                        string UserInput = Console.ReadLine();
                        if (UserInput == "Back" || UserInput == "back")
                        {
                            showMenu();
                        }
                        else { Console.WriteLine(""); }
                    }
                }
                
            }

            showMenu();
            
            void BorrowByName(int bookBorrow)
            {
                int j = 1;
                foreach (var book in Library)
                {
                    if (bookBorrow == j)
                    {
                        if (book.IsCheckedOut == true)
                        {
                            Console.WriteLine("We do not have this book in stock.");
                        } else
                        {
                            Console.WriteLine("You successfully borrowed the book.");
                            book.IsCheckedOut = true;
                        }
                    }
                    j++;
                }
               
            }
            
            void ViewBooks()
            {
                int i = 1;
                foreach (var book in Library)
                {
                    Console.WriteLine($"{i} - {book.Title} by {book.Author} ({book.Year})");  
                    i++;
                }
            }

            void AddBook()
            {
                Console.WriteLine("\nEnter the name of the book.");
                string newTitle = Console.ReadLine();
                Console.WriteLine("\nEnter the name of the books' author.");
                string newAuthor = Console.ReadLine();
                Console.WriteLine("\nEnter the year in which book was published.");
                int newYear = Convert.ToInt32(Console.ReadLine());
                Library.Add(new Book { Title = newTitle, Author = newAuthor, Year = newYear, IsCheckedOut = false });
                Console.WriteLine("\nNew book added!");
            }

            void RemoveBook(int removeBook)
            {
                Library.RemoveAt(removeBook - 1);
                Console.WriteLine("Book succsessfully deleted.");
            }
        }
    }
}
