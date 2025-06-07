using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z') ;
            {
                return true;
            }
            return false;
            



        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0);
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
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            var min = numbers.MaxValue;
            var max = numbers.MinValue;
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
            return numbers.Sum(x=>numbers.Sum(y => y));
        }

        public int SumEvens(int[] numbers)
        {
            int[] SumEvens;
            foreach (var x in numbers)
                if (x % 2 == 0)
                {
                    SumEvens = new[] {x};
                    
                }
            int sumAnswer = SumEvens.Sum();
            Console.WriteLine(sumAnswer);
         }

        public bool IsSumOdd(List<int> numbers)
        {
            
            List<int> SumOdd = new List<int> ();
            
            foreach (var y in numbers)
                if (y % 2 != 0)
                {
                    SumOdd.Add(y);
                }

            int sumAnswerOdd = SumOdd.AsQueryable().Sum();
            if (sumAnswerOdd % 2 != 0)
            {
                Console.WriteLine(sumAnswerOdd);
            }
            
            
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            
            List <long> counted = new List<long>();
            var sizeOfCounted = counted.Count;  
            long i;
            for (i = 0; i < number; i++)
            {
                if (i > 0 && i % 2 != 0)
                {
                    counted.Add(i);
                    return counted.Count;
                    
                }

            }

            Console.WriteLine("$ Count of Positive Odds is {sizeOfCounted}");
        }
    }
}
