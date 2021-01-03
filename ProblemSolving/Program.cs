using System;

namespace ProblemSolving
{
    class Program
    {

        //static void Fibonacci(int a)
        //{
            
           
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your nubmer...");
            int input1 = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c;
            
            for (int i = 0;; i++)
            {
                c = a + b;
                a = c - a;
                b = c;

                if (input1 == c)
                {
                    Console.WriteLine("Fibonacci");
                    break;
                }
                else if(input1<c)
                {
                    Console.WriteLine("не фибоначчи");
                    break;
                }
              
            }
            

        }

    }
    }

