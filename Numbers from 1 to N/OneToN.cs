using System;
    class OneToN
    {
        static void Main()
        {/*Write a program that enters from the console a positive integer n and 
          * prints all the numbers from 1 to n, on a single line, separated by a space*/
            Console.Write("Enter a positive integer: ");
            int n = int.Parse(Console.ReadLine());
            int result = 0;
                while (result < n)
                {
                    result++;
                    Console.Write(" {0}",result);
                }
        }
    }
