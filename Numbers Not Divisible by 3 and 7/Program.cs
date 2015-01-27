using System;

    class Program
    {
        static void Main()
        {
            /*Write a program that enters from the console a positive integer n and prints all the numbers 
             * from 1 to n not divisible by 3 and 7, on a single line, separated by a space.*/
            Console.Write("Enter a positive integer: ");
            int result = 0;
            int n = int.Parse(Console.ReadLine());
            for ( int i = 0; i < n; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                else if ( i % 7 ==0)
                {
                    continue;
                }
                else
                {
                    Console.Write(" {0} ", i);
                }
                result++;
            }
        }
    }
