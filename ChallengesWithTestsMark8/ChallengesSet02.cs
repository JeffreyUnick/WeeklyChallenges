using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals == null)
            {
                return false;
            }
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            } 
           return numbers.Min() + numbers.Max() ;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var length1 = str1.Length;
            var length2 = str2.Length;
            if (str1 == null || str2 == null)
            {
                return 0;
            }
            return length1 < length2 ? length1 : length2;
        }

        public int Sum(int[] numbers)
        {
            var sum = 0;
            if (numbers == null)
            {
                return 0;
            }
            for (var i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            var sum = 0;
            if (numbers == null)
            {
                return 0;   
            }
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            return numbers.Sum() % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number == null || number < 0)
            {
                return 0;
            }
            return number / 2;
        }
    }
}
