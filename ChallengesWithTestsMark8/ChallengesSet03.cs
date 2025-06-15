using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
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

            

            //Additional Method
            /* foreach (var item in vals)
                {
                    if (item == false)
                    {
                        return true;
                    }

                        return false;
                }    */
    
            //Additional Method
            // return vals != null && vals.Length != 0 && vals.Contains(false);
            
            //Additional Method
            /* var hasFalse = vals.Contains(false);
            var hasTrue = vals.Contains(true);
            if (vals != null && hasFalse != true)
            {
                return false;
            }
            if (hasFalse == true)
            {
                return true;
            }  */
            

        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            
            if (numbers == null)
            {
                return false;
            }
            if (numbers.Count() == 0)
            {
                return false;
            }
            
            var listSum = numbers.Sum();

            var newNum = new List<int>();
            
            
            foreach (var item in numbers)
                
                if (item % 2 != 0)
                {
                    newNum.Add(item);
                }

            if (numbers != null && newNum.Sum() % 2 != 0)
            {
                return true;
            }
                return false;
                
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            
            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber);


           //Additional Method
           /* Method 1
            bool upper2 = false;
            bool lower2 = false;
            bool hasNumber2 = false;

            foreach (var letter in password)
            {
                if (char.IsUpper(letter) == true)
                {
                    upper = true;
                }

                if (char.IsLower(letter) == true)
                {
                    lower = true;
                }

                if (char.IsNumber(letter) == true)
                {
                    hasNumber = true;
                }

                if (upper == true && lower == true && hasNumber == true)
                {
                    return true;
                }

                return false;   */



        }

           
        

        public char GetFirstLetterOfString(string val)
        {
            var userInput = val.ToArray();
            return userInput[0];
            
            //Additional Methods
            
           //Method 1:   return val[0];

            //Method 2:  return val.First();

        }

        public char GetLastLetterOfString(string val)
        {
            
            var userInput2 = val.ToArray();
            return userInput2[userInput2.Length - 1];

            
            //Additional Methods
            
            /* Method 1:
             
             val = val.ToArray();

            return val[val.Length - 1];  */

            // Method 2: return val.Last();

            // Method 3:  return val[^1];

            /* the caret symbol (^) is an operator that is a placeholder, which exempts all characters except
            the amount indicated by the digit in brackets */

        }

        public decimal Divide(decimal dividend, decimal divisor)
        {

            if (divisor == 0 || divisor == null)
            {
                return 0;
            }

            return dividend / divisor;

            //Additional Method
            // return divisor == 0 ? 0 : dividend / divisor;



        }

        public int LastMinusFirst(int[] nums)
        {
            return (nums[nums.Length - 1] - nums[0]);

            //Additional Methods
            // Method 1: return nums[^1] - nums[0];  OR
            // Method 2
            /* Re-factor
            var digitLast = nums[nums.Length - 1];
            var digitFirst = nums[0];
            return digitLast - digitFirst;  */

        }





        public int[] GetOddsBelow100()
        {

            
            return Enumerable.Range(1, 100).Where(x => x % 2 != 0).ToArray<int>();
            
            //Alternative Method
            /* var oddsBelow100 = new int[] { };
          
            int i;
            for (i = 1; i < 100; i+=2)
            {

                return oddsBelow100.Append(i).ToArray();


            } */


           
            



        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            
            
            //Additional Method
            //return words.ToUpper[words];
            

        }
    }
}   
