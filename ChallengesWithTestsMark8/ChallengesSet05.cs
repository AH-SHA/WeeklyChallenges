using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            startNumber++;
            while (startNumber % n != 0) 
                if (startNumber % n == 0)
                {
                    return startNumber;
                }
                    return 0;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            
            if (Business.GetValue(businesses) = 0)
            {
                return businesses.Replace(CLOSED);
            }
            
            //char[] busName = biz.ToCharArray();
            //return busName.Replace(TrueCoders);
            
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            var numAsc = numbers.OrderBy(x => x);
            if (numAsc == numbers)
            {
                return true;
            }
                return false;
                    
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            
            int i;
            for (i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    return numbers.Sum((numbers.Length) - (numbers.IndexOf([i])));
                }
            }
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            words.Concat(words);
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            double initialIndex =  elements.IndexOf(elements[0]);
            var i;
            for (i = 0; i < elements.Count; i += 4)
            {
                

                return initialIndex;
                
                var everyFourth = initialIndex(initialIndex.ToArray(i));
                return everyFourth;
            }

            //Alternative Methods
            //return elements.Skip(4).Take(4).ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            
            if (nums.Sum() == targetNumber)
            {
                return true;
            }
                return false;
            
            
            
        }
    }
}
