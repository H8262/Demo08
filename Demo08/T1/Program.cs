using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            Console.WriteLine("How many times you want to throw a dice?");
            int times = int.Parse(Console.ReadLine());
            Console.WriteLine("Dice values: ");
            int count = 0;

            int ones = 0;
            int twos = 0;
            int threes = 0;
            int fours = 0;
            int fives = 0;
            int sixes = 0;

            for (int i = times;i > 0; i--)
            {
                if (i == 0) break;
                count = dice.throwDice();
                if (count == 1) ones++;
                if (count == 2) twos++;
                if (count == 3) threes++;
                if (count == 4) fours++;
                if (count == 5) fives++;
                if (count == 6) sixes++;
            }
            double average = (ones + (twos * 2.0) + (threes * 3.0) + (fours * 4.0) + (fives * 5.0) + (sixes * 6.0)) / times;

            Console.WriteLine("1: " + ones);
            Console.WriteLine("2: " + twos);
            Console.WriteLine("3: " + threes);
            Console.WriteLine("4: " + fours);
            Console.WriteLine("5: " + fives);
            Console.WriteLine("6: " + sixes);
            Console.WriteLine("Average dice: " + average);
        }
    }
}
