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
            var singleNumber = 0;
            int.TryParse(numbers, out singleNumber);
            if (singleNumber != 0)
                return singleNumber;

            var isAllowed = AllowedDelimiters.Any(a => numbers.Contains(a));
            if (!isAllowed) return -1;
            
            var numbersStringList = numbers.Split(AllowedDelimiters);
            var numberList = numbersStringList
                .Select(number => int.Parse(number))
                .ToList();

            var isNumberNegative = numberList.Any(a => (a < 0));
            if(isNumberNegative)
                throw new Exception("Negatives not allowed");
            
            return numberList.Sum();
        }
    }
}