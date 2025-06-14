using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            

            int[] addList = new int[]{};
            int[] subList = new int[]{};
            
            var newList = numbers.ToList();
            var newListA = numbers.Sum();
            
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    subList.Append(number).ToArray();
                }
                    
                
                return newListA - subList.Sum();
            }
            
            //Additional Methods
            // return numbers.Where(x => x % 2 == 0).Sum() -  numbers.Where(x => x % 2 != 0).Sum();
            
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //Additional Method
            /*var newStr1 = str1.ToList();
            var newStr2 = str2.ToList();
            var newStr3 = str3.ToList();
            var newStr4 = str4.ToList();

            return Min(newStr1.Count(), newStr2.Count(),newStr3.Count(),newStr4.Count());   */

            var stringList = new List<int> {str1.Length, str2.Length, str3.Length,  str4.Length};
            return stringList.Min();
            
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var entries = new List<int> {number1, number2, number3, number4};
            return entries.Min();
            
            
            /*var num1 = number1.ToList();
            var num2 = number2.ToList();
            var num3 = number3.ToList();
            var num4 = number4.ToList();   
            
            
            return Min(num1, num2, num3, num4);  */
            
            
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            //Alternate Method
            // char[] busName = biz.ToCharArray();
            // return busName.Replace(TrueCoders);
            
            biz.Name = "TrueCoders"; 
            
            //When a method's return type is "void", you do not have to use the keyword "return" when using a
                  //parameter of that method.  You are just changing something or displaying the result, so you 
            //Tip - when a method has its own "<Class>" you need to try to view the properties for the method first 
                //before writing code for the parameter.
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            {
                return false;
                
            }
            if (sideLength1 + sideLength2 > sideLength3
                || sideLength2 + sideLength3 > sideLength1
                || sideLength1 + sideLength3> sideLength2)
            {
                return false;
            }
                return true;
                
        }
        
        // For a triangle, the sum of two sides has to be greater than the third side.

        public bool IsStringANumber(string input)
        {
            
            char [] inputNew2 = input.ToCharArray();
            return inputNew2.Any(char.IsNumber);
            
            // Additional Code
            // var inputNew = double.TryParse(input, out double number);
            // return inputNew;
            
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return (objs.Count(null) > (objs.Length/2 + 1)) ? true : false;
        }

        public double AverageEvens(int[] numbers)
        {
            List<int> numList = new List <int> ();

            if (numbers == null || numbers.Length == 0)
            {
                return 0.0;
                //Notice, the return value is "0" and not "true/false" because
                // the datatype of the input is "int"
            }
            
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    numList.Add(number);
                    
                }
            }

            return numList.Average();
            
            //Additional Methods
            //var num = numbers.Where(x => x % 2 == 0);
            //return num.Average();


        }

        public int Factorial(int number)
        {
            number = Math.Abs(number);
            if (number == 0) return 1;
            while (number >= 1)
            {
                return number * (number--);
            }

            return 0;


        }
    }
}
