using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;
            if (numbers == null)
                return false;
            else  
            {
                foreach (int number in numbers)
                {
                    if (number % 2 != 0)
                    {
                        sum += number;
                    }
                }
            }
            return sum % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit);
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] array = new int[50];
            for (int i = 0; i < 50; i++)
            {
               array[i] = 2*i + 1;
            }
            return array;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i< words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
