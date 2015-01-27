using System;
using System.Numerics;
    class CatalanNumbers
    {
        static void Main()
        {
            /*In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
             * Write a program to calculate the nth Catalan number by given n (1 <= n <= 100).*/
            Console.WriteLine("Enter a number for the position: ");
            int n = int.Parse(Console.ReadLine());

            BigInteger divident = 1;
            BigInteger divider = 1;
            if (n > 0 && n < 100)
            {
                for (int i = 2 * n; i > n + 1; i--)
                {
                    divident *= i;
                }
                for (int i = 1; i <= n; i++)
                {
                    divider *= i;
                }
                BigInteger result = divident / divider;
                Console.WriteLine("The Catalan number {0} is: {1}", n, result);
            }
            else
            {
                Console.WriteLine("The number must be bigger than zero");
            }
        }
    }
