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
            throw new NotImplementedException();
            if (Business.GetValue(businesses) = 0)
            {
                return businesses.Replace(CLOSED);
            }
            
            //char[] busName = biz.ToCharArray();
            //return busName.Replace(TrueCoders);
            
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            throw new NotImplementedException();
            var numAsc = numbers.OrderBy(x => x);
            if (numAsc = numbers)
            {
                return true;
            }
                return false;
                    
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
