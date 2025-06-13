using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            throw new NotImplementedException();

            int[] addList = new int[]{};
            int[] subList = new int[]{};
            var newList = numbers.ToList();
            foreach (int number in numbers)
            {
                if (number % 2 == 0)  ? newList.Add(number): newList.Remove(number);
            }
            
            //number % 2 == 0? numbers.Add(number) :numbers.RemoveAt(numbers.IndexOf(number);
            
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var newStr1 = str1.ToList();
            var newStr2 = str2.ToList();
            var newStr3 = str3.ToList();
            var newStr4 = str4.ToList();

            return Max(newStr1.Count(), newStr2.Count(),newStr3.Count(),newStr4.Count());

            int Max(int count, int i, int count1, int i1)
            {
                throw new NotImplementedException();
            }
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            list entries = new List<int> {number1, number2, number3, number4};
            var num1 = number1.ToList();
            var num2 = number2.ToList();
            var num3 = number3.ToList();
            var num4 = number4.ToList();   
            
            return Min(num1, num2, num3, num4);
            
            
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            char[] busName = biz.ToCharArray();
            return busName.Replace(TrueCoders);
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 == null || sideLength1 < 0 || sideLength2 == null ||
                sideLength2 < 0 && sideLength3 == null || sideLength3 < 0)
            {
                return false;
            }
                return true;
        }

        public bool IsStringANumber(string input)
        {
            char [] inputNew = input.ToCharArray();
            return inputNew.Any(char.IsNumber);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return (objs.Count(null) > objs.Length/2) ? true : false;
        }

        public double AverageEvens(int[] numbers)
        {
            List<int> numList = new List <int> ();
            
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    numList.Add(number);
                    
                }
            }

            numList.Average();

        }

        public int Factorial(int number)
        {
            number = Math.Abs(number);
            if (number == 0) return 1;
            while (number >= 1)
            {
                return number * (number--);
            }
            
            
        }
    }
}
