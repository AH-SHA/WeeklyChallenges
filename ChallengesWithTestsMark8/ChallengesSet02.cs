using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z') 
            {
                return true;
            }
                return false;
            
            

        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
                return false;
                
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
                return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
                return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            var  min = numbers.Max();
            var  max = numbers.Min();
            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var len1 = str1.Length;
            var len2 = str2.Length;
            var len = Math.Min(len1, len2);
            return len;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            return numbers.Sum();
            

        }
        

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
                return numbers.Where(x => x % 2 == 0).Sum();
                    
        }

        public bool IsSumOdd(List<int> numbers)
        {
            
           if (numbers == null)
           {
               return false;
           }

           if (numbers.Sum() % 2 != 0)
           {
               return true;
           }
               return false;

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
                
            }
            
                return ((Math.Abs(number))) / 2;
                
        }
    }
}
