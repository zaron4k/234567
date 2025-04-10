using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    abstract class Book
    {
        protected string title, author;
        protected int year, price;
            public string Title
        {
            get;
            set;
        }
        public string Author
        {
            get;
            set;
        }
        public int Year
        {
            get;
            set;
        }
        public int Price
        {
            get;
            set;
        }
        public Book() { }
        public Book(string title, string author, int year, int price) 
        {
            this.Title = title;
            this.Author = author;
            this.Year = year;
            this.Price = price;
        }
    }
}
