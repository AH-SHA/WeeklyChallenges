using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {


            bool hasWord = false;
            
            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }
            
            if (ignoreCase == true)
            {
                word = word.ToLower();
                List <string> lowerC = words.Select(x => x.ToLower()).ToList();
                hasWord = lowerC.Contains(word);
                
            }

            if (ignoreCase == false)
            {
                hasWord = words.Contains(word);
            }
            
            return hasWord;

        }

        public bool IsPrimeNumber(int num)
        {
           if (num <= 1)
            {
                return false;
            }

            if (num == 2 || num == 3 || num == 5 || num == 7)
            {
                return true;
            }

            if (num % 2 == 0 && num != 2 || num % 3 == 0 && num != 3 || num % 5 == 0 && num != 5 || num % 7 == 0)
            {
                return false;
            }
                 return true;
                
            
        }

        public int IndexOfLastUniqueLetter(string str)
        {
           
            

            int index = -1;
            bool uniqueLetter;

            for (int i = 0; i < str.Length; i++)
            {
                uniqueLetter = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uniqueLetter = false;
                    }
                   
                }

                if (uniqueLetter == true)
                {
                    index = i;
                }
                
                
            }

            return index;

            //Refactor the code below
            //var strArray = str.ToCharArray();
            //strArray.DistinctBy((x => x.Index));
            //strArray.Distinct().ForEach(x => str = strArray.IndexOf([x]).ToArray());



        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            

            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int count2 = 1;

                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    
                        count2++;
                        
                    
                    
                }

                if (count2 > count)
                {
                    count = count2;
                }
              
            }

            return count;

        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            
            List <double> nElement =  new List<double>();
            
            // a list is used above because of its flexibility, but the final answer will need to match the
            // expected type indicated by the method "double []" and array of doubles.
            //Remember at the end to convert the list to an array.

            if (elements == null || n <= 0 || n > elements.Count)
            {
                return nElement.ToArray();
            }

            for (var i = n - 1; i < elements.Count; i += n)
            {
                nElement.Add(elements[i]);
            }


            return nElement.ToArray();

        }
    }
}
