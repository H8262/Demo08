using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Dice
    {
        Random rand = new Random();

        public int value;

        public int throwDice()
        {
            value = rand.Next(1, 7);
            return value;
        }


    }
}
