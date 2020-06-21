using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3
{
    class Book
    {
        public string author, title;
        private int pageCount;
        public bool collection;

        public Book()
        {
            this.author = "Стивен Кинг";
            this.title = "Темная башня";
            this.pageCount = 865;
            this.collection = true;
        }
        public Book(string author, string title, int pageCount, bool collection)
        {
            this.author = author;
            this.title = title;
            this.pageCount = pageCount;
            this.collection = collection;
        }
        public Book(string author, string title, int pageCount)
        {
            this.author = author;
            this.title = title;
            this.pageCount = pageCount;
            this.collection = false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    
}
