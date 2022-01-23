using System;
using System.Collections.Generic;
using System.Collections;

namespace Chapter_14_Definng_classes
{
    public class Book
    {
        
        public string Title { get; set; }
        public  string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime TimeReleased { get; set; }


        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            ISBN = GetISBN();
            TimeReleased=DateTime.Now;
            
        }


        public string GetISBN()
        {
             return $"{Guid.NewGuid().ToString().Substring(0,6)}";
            
        }    
    }
}