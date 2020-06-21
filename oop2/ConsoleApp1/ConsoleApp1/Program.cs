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
            tvChanel Tv = new tvChanel();

            Tv.curChanel = 1;

            int answer;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Нынешний канал канал- " + Tv.curChanel);
                Console.WriteLine("\n1 - Предыдущий канал\n2 - Следующий канал\n3 - Ввести канал");
                if (int.TryParse(Console.ReadLine(), out answer))
                {
                    switch (answer)
                    {
                        case 1: Tv.prevChannel(); break;
                        case 2: Tv.nextChannel(); break;
                        case 3: Tv.changChannel(); break;
                        default: break;
                    }
                }
            }
        }
    }

    class tvChanel
    {
        public int curChanel;

        public void changChannel()
        {
            Console.WriteLine("Введите канал");

            if (int.TryParse(Console.ReadLine(), out int channel) && channel > 0)
            {
                curChanel = channel;
            }
        }

        public void nextChannel()
        {
            curChanel++;
        }

        public void prevChannel()
        {
            if (curChanel > 1) curChanel--;
        }
    }
}

