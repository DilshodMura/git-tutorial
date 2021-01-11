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
    }
}