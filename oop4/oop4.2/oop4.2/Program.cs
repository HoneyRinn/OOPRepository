using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4._2
{
    class bookYear
    {
        private int year;
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value >= 1940 && value <= 2020) year = value;
            }
        }
        public bookYear()
        {
            this.year = 1940;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bookYear book = new bookYear();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Стандартное значение - " + book.Year);
                Console.WriteLine("Новое значение- ");
                int.TryParse(Console.ReadLine(), out int newYear);
                book.Year = newYear;
            }
        }
    }
}
