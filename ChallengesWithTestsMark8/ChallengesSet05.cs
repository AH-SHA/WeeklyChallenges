using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
        
        //Additional Method
        // return ((startNumber / n) + 1) * n;

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            if (business.TotalRevenue == 0)
            {
                business.Name = "CLOSED";
            }
            
            // Tip -- You have to review the parameters in the class to build the loop and if statement.
            //Notice, businesses is an array in this problem set, as opposed to it being one value in Challenges 04 set.
            // Make sure you iterate through each value in the array.
            
            //Alternative Method
            
            /*
            for(var i =0; i < businesses.Length; i++)
            if (businesses[i].TotalRevenue == 0)
            {
                businesses[i].Name = "CLOSED";
                
            }  */
                
            
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for (var i = 1; i < numbers.Length; i++)
            { 
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;
                
                //Sort  Ascending order Using LINQ
                //var numAsc = numbers.OrderBy(x => x);
                
                //Refactor Code Below
                /* int[] numASC = Array.Sort(numbers);
            
                if (numASC == numbers)
                {
                    return true;
                }
                return false;  */
                
                    
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int sumElements = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] % 2 == 0)
                {
                    
                    sumElements += numbers[i];

                }
            }
            return sumElements;
            
            
            // Refactor Code Below Later
            /*int i;
            for (i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    return numbers.Sum((numbers.Length) - numbers[numbers.IndexOf([i])]);
                }
            }  */
            
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return string.Empty;
                // OR  return "";
            }
            string sentence = string.Empty;
            for (int i = 0; i < words.Length; i++)

                foreach (string word in words)
                {
                    if (word.Trim().Length > 0)
                    {
                        sentence += word.Trim() + " ";
                    }
                }

            if (sentence.Length == 0)
            {
                return string.Empty;
            }
            sentence = sentence.TrimEnd();
            sentence = sentence.TrimStart();
            sentence = sentence += ".";
            return sentence;
            
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return Array.Empty<double>();
                //OR new double [0];
            }
            
            List<double> everyFourth = new List<double>();
            
            
            for (var i = 3; i < elements.Count; i += 4)
            {
                everyFourth.Add(elements[i]);
                
            }
            
            return everyFourth.ToArray();
            
            //Alternative Method
            //return elements.Skip(4).Take(4).ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length == 0 || targetNumber == null)
            {
                return false;

            }

            if (nums.Sum() == targetNumber)
            {
                return true;
            }
                return false;
            
            //Additional Method
            // Nested For-Loop
            /* for (int i = 0; i < nums.Length; i++)
             {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                } 
            } */
             
            
            
        }
    }
}
