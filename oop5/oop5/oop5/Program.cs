using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop5
{
    class People
    {
        public string Name, SurName;

        public People()
        {
            Name = "Norman"; SurName = "Osborn";
        }
        public People(string Name, string SurName)
        {
            this.Name = Name; this.SurName = SurName;
        }

        public void Display()
        {
            Console.WriteLine(Name + " " + SurName);
        }
        public void Display(string comp)
        {
            Console.WriteLine(Name + " " + SurName + ", " + comp);
        }
    }

    class Zanyatost : People
    {
        public string company;

        public Zanyatost() : base("Otto", "Octavius")
        {
            company = "Microsoft";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            People p = new People();
            Zanyatost zan = new Zanyatost();

            p.Display();
            zan.Display(zan.company);

            Console.ReadKey();
        }
    }
}
