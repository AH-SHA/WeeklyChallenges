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
            return false;
            
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
            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber);
            
            
            var passConvert = (Console.ReadLine());
            char [] passConvArray = passConvert.ToCharArray();
            //passConvert.ToCharArray();

            bool upper = char.IsUpper(passConvArray());
            bool lower = char.IsLower(passConvArray());
            bool hasNumber = passConvert.Any();
            
            //var passConvert2 = passConvert.Any();
            List<char> passEntry = new List<char>();

            foreach (var item in passConvArray)
            {
                if (char.IsUpper(passConvArray[item]) || char.IsLower(passConvArray[item]) ||
                    char.IsNumber(passConvArray[item])) 
                {
                    return true;
                }
                    return false;
                passEntry.Add(item);
            }

            if (passEntry.Count > 0)
            {
                return false;
            }
                
        }

        public char GetFirstLetterOfString(string val)
        {
            var userInput = Console.ReadLine();
            userInput = new string(userInput.ToArray());
            return userInput[0];
        }

        public char GetLastLetterOfString(string val)
        {
            var userInput2 = Console.ReadLine();
            userInput2 = new string(userInput2.ToArray());
            return userInput2.Length - 1;

           
            val = val.ToArray();
            return val.Length - 1;
        }
        
        public decimal Divide(decimal dividend, decimal divisor)
        {
           
            var quotient =  dividend / divisor;
            if (divisor == 0 || divisor == null || quotient == null)
            {
                Console.WriteLine("Not divisible");
            }
           

        }

        public int LastMinusFirst(int[] nums)
        {
            int digitLast = (nums.Length - 1);
            //(nums.Length-1) - (nums[0]);
            int digitFirst = nums[0];
            return digitLast - digitFirst;

        }

        public int[] GetOddsBelow100()
        {
            throw new NotImplementedException();
            int i;
            for (i = 1; i <= 100; i+2)
            {
                return [i];
            }

        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            return string.ToUpper(words);

        }
    }
}
