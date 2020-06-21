using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            ZooShop zShop = new ZooShop();
            Console.WriteLine("Инфо о животном:");
            Console.WriteLine("Животное- ");
            zShop.Animal = Console.ReadLine();
            Console.WriteLine("Пол- ");
            zShop.Sex = char.Parse(Console.ReadLine());
            Console.WriteLine("Имя- ");
            zShop.Name = Console.ReadLine();
            Console.WriteLine("Цена- ");
            zShop.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во- ");
            zShop.Quant = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Животное- " + zShop.Animal);
            Console.WriteLine("Пол- " + zShop.Sex);
            Console.WriteLine("Имя- " + zShop.Name);
            Console.WriteLine("Цена- " + zShop.Price);
            Console.WriteLine("Кол-во- " + zShop.Quant);

            Console.ReadKey();
        }
    }

    class ZooShop
    {
        public string Animal, Name;

        public char Sex;

        public int Price, Quant;
    }
}
