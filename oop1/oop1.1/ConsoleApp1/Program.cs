using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokupatel pokupatel = new Pokupatel();

            pokupatel.Surname = "Федоров";
            pokupatel.Name = "Илья";
            pokupatel.FamilyName = "Романович";
            pokupatel.Address = "г. Каменск-Уральский, ул. Маяковская, 3, 2";
            pokupatel.CardNum = "1111222233334444";
            pokupatel.BankNum = "1231231231231412414414";

            Console.Write("Фамилия \t" + pokupatel.Surname + "\n");
            Console.Write("Имя \t" + pokupatel.Name + "\n");
            Console.Write("Отчество \t" + pokupatel.FamilyName + "\n");
            Console.Write("Адрес \t" + pokupatel.Address + "\n");
            Console.Write("Номер карты \t" + pokupatel.CardNum + "\n");
            Console.Write("Номер банковского счета \t" + pokupatel.BankNum + "\n");

            Console.ReadKey();
        }
    }

    class Pokupatel
    {
        public string Surname, Name, FamilyName, Address, CardNum, BankNum;
    }
}
