using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Abonent abonent = new Abonent();
            Console.WriteLine("Информация об абоненте:");
            Console.WriteLine("Идентификационный номер - ");
            abonent.ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Ф.И.О. - ");
            abonent.Names = Console.ReadLine().Split(' ');
            Console.WriteLine("Номер карты - ");
            abonent.CardNum = Console.ReadLine();
            Console.WriteLine("Время городских переговоров - ");
            abonent.ccTime = Console.ReadLine();
            Console.WriteLine("Время междугород. разговоров - ");
            abonent.outccTime = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Абонент:");
            Console.WriteLine("Идентиф. номер - " + abonent.ID);
            Console.WriteLine("Ф.И.О. - {0} {1} {2}", abonent.Names[0], abonent.Names[1], abonent.Names[2]);
            Console.WriteLine("Номер карты - " + abonent.CardNum);
            Console.WriteLine("Время городских переговоров - " + abonent.ccTime);
            Console.WriteLine("Время междугород. разговоров - " + abonent.outccTime);

            Console.ReadKey();
        }
    }

    class Abonent
    {
        public int ID;
        public string[] Names;
        public string CardNum, ccTime, outccTime;
    }
}

