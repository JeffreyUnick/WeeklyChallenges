using System;
using System.Linq;
using System.Collections.Generic;
namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
           var sumEven = numbers.Where(x => x % 2 == 0).ToList().Sum();
           var sumOdd = numbers.Where(x => x % 2 != 0).ToList().Sum();
           return sumEven - sumOdd;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> strList = new List<string>();
            strList.Add(str1);
            strList.Add(str2);
            strList.Add(str3);
            strList.Add(str4);
            strList = strList.OrderBy(x => x.Length).ToList();
            return strList[0].Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var listOfNumbers = new List<int>();
            listOfNumbers.Add(number1);
            listOfNumbers.Add(number2);
            listOfNumbers.Add(number3);
            listOfNumbers.Add(number4);
            listOfNumbers = listOfNumbers.OrderBy(x => x).ToList();
            return listOfNumbers[0];
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
           return objs.Where(x => x == null).ToList().Count() > objs.Count()/2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            var evenList = numbers.Where(x => x % 2 == 0).ToList();
            if (evenList.Count() == 0)
            {
                return 0;
            }
            else  return evenList.Average();
        }

        public int Factorial(int number)
        {
            var result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
