using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorMaaiHam
{
    public static class StringCalculator
    {
        private static readonly char[] AllowedDelimiters = {';', '.', ','};
        public static int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers)) return 0;

            var isAllowed = AllowedDelimiters.Any(a => !numbers.Contains(a));
            if (isAllowed) return -1;
            
            var numbersStringList = numbers.Split(",").ToList();

            var numberList = numbersStringList
                .Select(number => int.Parse(number));
            
            return numberList.Sum();
        }
    }
}