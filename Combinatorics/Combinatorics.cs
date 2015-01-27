using System;
using System.Numerics;
    class Combinatorics
    {
        static void Main()
        {
            /*In combinatorics, the number of ways to choose k different members out of a group of n different 
             * elements (also known as the number of combinations) is calculated by the following formula: 
             * formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
             * Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100).
             * Try to use only two loops.*/
            Console.WriteLine("Enter N (must be > 1): ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K(must be < n and < 100): ");
            int k = int.Parse(Console.ReadLine());

            BigInteger sum1 = 1;
            BigInteger sum2 = 1;

            if (1 < k && n > k && n < 100)
            {
                for (int i = k + 1; i <= n; i++)
                {
                    sum1 *= i;
                }
                for (int f = 1; f <= (n - k); f++)
                {
                    sum2 *= f;
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            BigInteger sum3 = sum1 / sum2;
            Console.WriteLine("The answer is {0}", sum3);
        }
    }
