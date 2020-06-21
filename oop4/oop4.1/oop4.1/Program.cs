using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4._1
{
    class Health
    {
        private int temp;
        public int publickTemp
        {
            get{ return temp;}
            set
            {
                if (value >= 34 && value <= 41) temp = value;
            }
        }
        public Health()
        {
            this.temp = 36;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Health health = new Health();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Нормальная температура - " + health.publickTemp);
                Console.WriteLine("Ваше значение - ");
                int.TryParse(Console.ReadLine(), out int newTemp);
                health.publickTemp = newTemp;
            }
        }
    }
}
