using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorMaaiHam
{
    public static class StringCalculator
    {
        public static int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers)) return 0;
            var numbersStringList = numbers.Split(",").ToList();
            var total = 0;
            foreach(var stringNumber in numbersStringList)
            {
                 total += int.Parse(stringNumber);
            }
            return total;
        }
    }
}