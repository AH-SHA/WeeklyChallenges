using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            //var hasFalse = vals.Contains(false);
            //var hasTrue = vals.Contains(true);
           
            if (vals == null || vals.Length == 0)
            {
                return false;
            }
            if (vals.Contains(false) == false)
            {
                return false;
            }
            if (vals.Contains(false) == true)
            {
                return true;
            }
            
            // if (vals != null && hasFalse != true)
            // {
            //     return false;
            // }
            // if (hasFalse == true)
            // {
            //     return true;
            // }
            //
                
                
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var listSum = numbers.Sum();
            
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            if (listSum % 2 != 0)
            {
                return true;
            }
                return false;
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val)
        {
            throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {
            throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
        }
    }
}
