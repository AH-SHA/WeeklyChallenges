using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {

            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();

            
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var stringList = new List<int> {str1.Length, str2.Length, str3.Length,  str4.Length};
            return stringList.Min();
            
            
            //Additional Methods:
            /*var newStr1 = str1.ToList();
            var newStr2 = str2.ToList();
            var newStr3 = str3.ToList();
            var newStr4 = str4.ToList();

            return Min(newStr1.Count(), newStr2.Count(),newStr3.Count(),newStr4.Count());   */
            
            
            
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var entries = new List<int> {number1, number2, number3, number4};
            return entries.Min();
            
            //Additional Methods:
            /*var num1 = number1.ToList();
            var num2 = number2.ToList();
            var num3 = number3.ToList();
            var num4 = number4.ToList();   
            
            
            return Min(num1, num2, num3, num4);  */
            
            
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders"; 
            
            //When a method's return type is "void", you do not have to use the keyword "return" when using a
                  //parameter of that method.  You are just changing something or displaying the result, so you
                  //don't need to "return" anything
            //Tip - when a method has its own "<Class>" you need to try to view the properties for the method first 
                //before writing code for the parameter.
                
            //Additional Methods
            // char[] busName = biz.ToCharArray();
            // return busName.Replace(TrueCoders);    
                
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            {
                return false;
                
            }
            if (sideLength1 + sideLength2 <= sideLength3
                || sideLength2 + sideLength3 <= sideLength1
                || sideLength1 + sideLength3 <= sideLength2)
            {
                return false;
            }
                return true;
                
        }
        
        // For a triangle, the sum of two sides has to be greater than the third side.

        public bool IsStringANumber(string input)
        {
            if (input == null || input.Length == 0)
            {
                return false;
            }
            var inputNew = double.TryParse(input, out double number);
            return inputNew;
            
            
            // Additional Code
            /* if (input == null || input.Length == 0)
            {
                return false;
            }

            if (input < 0.0)
            {
                return true;
            }
            char [] inputNew2 = input.ToCharArray();
            return inputNew2.All(char.IsNumber); */
            
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var length = objs.Length;
            var majority = length/2 + 1;
            var counter = 0;

            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    counter++;
                }
            }
            if (counter >= majority)
            {
                return true;
            }
                return false;
                
            
        }

        public double AverageEvens(int[] numbers)
        {
            double sum = 0;
            double count = 0;
            
            //List<int> numList = new List <int> ();

            if (numbers == null || numbers.Length == 0)
            {
                return 0.0;
                //Notice, the return value is "0" and not "true/false" because
                // the datatype of the input is "int"
            }
            
            foreach (var number in numbers)
            {
                
                if ((number % 2 == 0) || (((number * -1) % 2) == 0))
                {
                    sum+=number;
                    count++;
                }
                    
                
            }

            if (count > 0)
            {
                return sum/count;
            }
                return 0;

            

            //Additional Method
            // var num = numbers.Where(x => x % 2 == 0);
            // return num.Average();


        }

        public int Factorial(int number)
        {
            int factorial = 1;
            
            
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number == 0)
            {
                return 1;
            }
            
            for(int i = number; i > 0; i--)
            {
                factorial *= i;
            }
          
            return factorial;
            
        }
    }
}
