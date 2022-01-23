using System;
using System.Collections.Generic;
using System.Collections;
namespace Chapter_14_Definng_classes
{
    public class Library : Book
    {
        public const string Name="Scholars Library";
        public  static List<Book> books=new List<Book>();


        public Library(string author,string title) :base(title,author)
        {
            
            Author = author;
            Title = title;
            ISBN = GetISBN();
        }
        public void AddBook()
        {
            Console.WriteLine("Enter book Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter book Author: ");
            string author = Console.ReadLine();
            Library b=new Library(author,title);
            string f = b.ISBN;
            books.Add(b);
            Console.WriteLine($"The book ISBN is {f}");

        }

        public static void ListBooks()
        {
            if (books.Count==0)
            {
                Console.WriteLine("No book is not available");
                
            }
            else
            {
                foreach (var b in books)
                {
                    if (books.Contains(b))
                    {
                        Console.WriteLine($"The book name is {b.Title}  and the author is {b.Author}.The book ISBN is {b.ISBN} the book was relesed at{b.TimeReleased} ");
                    }
                }
            }
        }

        public void RemoveBook()
        {
            Console.WriteLine("Enter book Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter book Author: ");
            string author = Console.ReadLine();
            Console.WriteLine("Enter book ISBN: ");
            string isbn = Console.ReadLine();
            foreach (var b in books)
            {
                if (b.ISBN==isbn && b.Author==author)
                {
                    books.Remove(b);
                    break;
                }
            }
            Console.WriteLine("The book has been removed");
        }
    }
}