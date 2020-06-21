using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop6._2
{
    class Text
    {
        private string text;
        public void setText(string input)
        {
            if (input.Length > 10) text = "Сделайте текст кароче";
            else text = input;
        }
        public void Display()
        {
            Console.WriteLine(text);
        }
        public void setText()
        {
            text = "Пусто";
        }      
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            Text txt = new Text();
            string input = Console.ReadLine();
            if (input.Length == 0) txt.setText();
            else txt.setText(input);
            txt.Display();

            Console.ReadKey();
        }
    }
}
