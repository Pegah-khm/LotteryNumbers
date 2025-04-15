using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumbers
{
    public static class LotteryGenerator
    {
        private static Random rand = new Random();
        private static int bonus;


        public static List <int> GenerateNumbers (int count)
        {
            List<int> numbers = new List<int>();
            while (numbers.Count < count)
            {
                int n = rand.Next(1, 50);
                if (!numbers.Contains(n))
                    numbers.Add(n);
            }
            numbers.Sort ();
            return numbers;
        }


        public static int GenerateBonusNumber(List<int> numbers)
        {
            do
            {
                bonus = rand.Next(1, 50);
            } while (numbers.Contains(bonus));

            return bonus;
        }


        public static void SetColourForNumber(int n)
        {
            //The numbers shall have a different coloured background: 1-9 grey, 10-19 blue, 20-29, pink, 30-39 green, 40-49 yellow.
            Console.ForegroundColor = n switch
            {
                >= 1 and <= 9 => ConsoleColor.Gray,
                >= 10 and <= 19 => ConsoleColor.Blue,
                >= 20 and <= 29 => ConsoleColor.Magenta,
                >= 30 and <= 39 => ConsoleColor.Green,
                _ => ConsoleColor.Yellow
            };
        }

        public static void DisplayNumbers (List <int> numbers, int bonus)
        {
            Console.Write("Your lottery numbers are:\nMain numbers: ");
            foreach (int n in numbers)
            {
                SetColourForNumber(n);
                Console.Write($"{n} ");
            }
            ResetConsoleColour();
            Console.Write("\nBonus Ball: ");
            SetColourForNumber(bonus);
            Console.WriteLine(bonus);
            ResetConsoleColour();
        }

        public static void ResetConsoleColour()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}
