using System;

namespace ProblemSolving
{
    class Program
    {

        //Method for Fibonacci sequence
        static void Fibonacci()
        {
            int input1 = int.Parse(Console.ReadLine());
            int input = 0;
            int input2 = 1;
            int result;

            for (int i = 0; ; i++)
            {
                result = input + input2;
                input = result - input;
                input2 = result;

                //inserted while loop instead of if else statement
                while ((input1 == result) && (input1 < result))
                {
                    Console.WriteLine("Fibonacci");
                    break;
                }

            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your nubmer...");
            //Calling Fibonacci method
            Fibonacci();

        }

    }

}

