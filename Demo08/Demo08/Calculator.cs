﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08
{
    public class Calculator : ICalculator
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
