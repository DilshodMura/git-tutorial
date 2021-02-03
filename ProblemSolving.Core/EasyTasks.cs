using System;
using System.Collections.Generic;

namespace ProblemSolving.Core
{
   
    public class EasyTasks
    {
        public bool IsFibonacci(int inputNumber)
        {
            int numberOne = 0;
            int numberTwo = 1;
            int result;

            while (true)
            {
                result = numberOne + numberTwo;
                numberOne = result - numberOne;
                numberTwo = result;
                if (inputNumber == result)
                {
                    return true;
                }
                else if (inputNumber < result)
                {
                    return false;
                }
            }
        }

        public int SumOfTwo(int firstInput, int secondInput)
        {
            return firstInput + secondInput;
        }

        public List<string> FooBuzz(List<int> inputNumbers)
        {
            // return list of strings that would contain the result
            // divided by 2 - Foo
            // divided by 3 - Buzz
            // divided by both 2 && 3 - FooBuzz 
            // not divded by any 2 or 3 - FooBuzzBar

            // loop through list of integers and append respective string
            // to the list of string and return 
            // input example {1, 2, 3, 4, 5, 6}
            // return example: {"Foo", "Buzz", "FooBuzzBar", "Buzz"}

            // TODO: 
            // Solution:
            List<string> resultFooBuzz = new List<string>(); 
            foreach (var item in inputNumbers)
            {
                if (item % 2 == 0 && item % 3 == 0)
                {
                    resultFooBuzz.Add("FooBuzz");
                }
                else if (item % 3 == 0)
                {
                    resultFooBuzz.Add("Buzz");
                }
                else if (item % 2 == 0)
                {
                    resultFooBuzz.Add("Foo");
                }
                else
                {
                    resultFooBuzz.Add("FooBuzzBar");
                }
            }
            return resultFooBuzz;
        }
    }
}