using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop6._3
{
    class Triangle
    {
        public double a, b, c, Alp, Bet, Fi;

        public bool CheckExistence()
        {
            if (a + b > c && a + c > b && b + c > a)
                return 
                    true;
            else
                return 
                    false;
        }
        public void CalculateAngles()
        {
            Alp = Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b)) * 180 / Math.PI;
            Bet = Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c)) * 180 / Math.PI;
            Fi = Math.Acos((Math.Pow(c, 2) + Math.Pow(b, 2) - Math.Pow(a, 2)) / (2 * c * b)) * 180 / Math.PI;
            Console.WriteLine("Углы равны: {0:#.##} градусов, {1:#.##} градусов, {2:#.##} градусов", Alp, Bet, Fi);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        Open:
            Console.Clear();
            Triangle tr = new Triangle();
            Console.WriteLine("Введите стороны треугольника:");
            string[] trStor = Console.ReadLine().Split(' ');

            try
            {
                if (trStor.Length > 3) goto Open;
                tr.a = double.Parse(trStor[0]);
                tr.b = double.Parse(trStor[1]);
                tr.c = double.Parse(trStor[2]);
            }

            catch (Exception)
            {
                goto Open;
            }

            if (tr.CheckExistence())
            {
                Console.WriteLine("Такой треугольник есть");
                tr.CalculateAngles();
            }
            else Console.WriteLine("Треугольника не существует");

            Console.ReadKey();
        }
    }
}
