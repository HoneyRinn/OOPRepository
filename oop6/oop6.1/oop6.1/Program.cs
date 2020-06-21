using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop6._1
{
    class Numbers
    {
        public int numA, numB;
        Random rnd = new Random();

        public Numbers()
        {
            numA = rnd.Next(1, 10); numB = rnd.Next(1, 10);
        }
        public Numbers(int input)
        {
            numA = input; numB = rnd.Next(1, 10);
        }
        public Numbers(int input1, int input2)
        {
            numA = input1; numB = input2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2-х значное число");
            string input = Console.ReadLine();

            if (input.Length == 0)
            {
                Numbers num0 = new Numbers();
                Console.WriteLine("a = {0}, b = {1}", num0.numA, num0.numB);
            }
            else
            {
                string[] inputParsed = input.Split(' ');
                int[] nums = new int[inputParsed.Length];
                for (int i = 0; i < nums.Length; i++)
                {
                    if (int.TryParse(inputParsed[i], out nums[i]) == false)
                    {
                        Console.WriteLine("Введите числа!");
                        goto theEnd;
                    }
                }
                switch (nums.Length)
                {
                    case 1:
                        Numbers num1 = new Numbers(nums[0]);
                        Console.WriteLine("a = {0}, b = {1}", num1.numA, num1.numB);
                        break;
                    case 2:
                        Numbers num2 = new Numbers(nums[0], nums[1]);
                        Console.WriteLine("a = {0}, b = {1}", num2.numA, num2.numB);
                        break;
                    default:
                        break;
                }
            }
            theEnd:
            Console.ReadKey();
        }
    }
}
