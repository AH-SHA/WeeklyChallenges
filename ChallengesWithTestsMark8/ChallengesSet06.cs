using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            return words.Contains(word,ignoreCase());
        }

        public bool IsPrimeNumber(int num)
        {
            throw new NotImplementedException();
            
        }

        public int IndexOfLastUniqueLetter(string str)
        {
           
            var strArray = str.ToCharArray();
            //strArray.DistinctBy((x => x.Index));
            strArray.Distinct().ForEach(x => str = strArray.IndexOf([x]));

        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            Math.Max(numbers.Count());
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            nGiven =  IndexOf(elements);
            var i;
            
            for (i = 0; nGiven< elements.Count; i+=n)
            {
                //return elements.Skip(4).Take(4).ToArray();

                //return initialIndex;
                
                var everyNth = i.ToArray();
                return everyNth;
            }
        }
    }
}
