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

            foreach (var item in vals)
            {
                if (item == false)
                {
                    return true;
                }

                return false;
            }

            return vals != null && vals.Length != 0 && vals.Contains(false);

        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var listSum = numbers.Sum();

            var newNum = new List<int>();

            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            foreach (var item in numbers)
                if (item % 2 != 0)
                {
                    newNum.Add(item);
                }

            if (newNum.Sum() % 2 != 0)
            {
                return true;
            }

            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber);


            var passConvert = (Console.ReadLine());
            char[] passConvArray = passConvert.ToCharArray();
            //passConvert.ToCharArray();

            bool upper = char.IsUpper(passConvArray());
            bool lower = char.IsLower(passConvArray());
            bool hasNumber = char.IsNumber(passConvArray());

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

                return false;



            }

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

            return val[0];

            return val.First();

        }

        public char GetLastLetterOfString(string val)
        {
            var userInput2 = Console.ReadLine();
            userInput2 = new string(userInput2.ToArray());
            return userInput2.Length - 1;


            val = val.ToArray();

            return val[val.Length - 1];

            return val.Last();

            return val[^1];

            /* the caret symbol is an operator that is a placeholder exempting all characters except
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
            return divisor == 0 ? 0 : dividend / divisor;



        }

        public int LastMinusFirst(int[] nums)
        {
            int digitLast = (nums.Length - 1);
            //(nums.Length-1) - (nums[0]);
            int digitFirst = nums[0];
            return digitLast - digitFirst;

            //Additional Methods

            return nums[^1] - nums[0];

            return nums[nums.Length - 1] - nums[0];

        }





        public int[] GetOddsBelow100()
        {

            int i;
            var oddsBelow100 = new int[] { };

            for (i = 1; i <= 100; i += 2)
            {

                return oddsBelow100 = oddsBelow100.Append(i).ToArray();


            }


            //Additional method
            return Enumerable.Range(1, 100).Where(x => x % 2 != 0).ToArray<int>();



        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            //return words.ToUpper[words];

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

        }
    }
}   
