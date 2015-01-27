using System;
using System.Numerics;
    class CalculateNandK
    {
        static void Main()
        {
            /*Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
             * Use only one loop.*/
            Console.Write("Enter the k integer(must be smaller than the second integer and under 100): ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Enter the n integer(must be bigger than the second integer and under 100): ");
            int n = int.Parse(Console.ReadLine());
            BigInteger sum = 1;
            if (1 < k && k < n && n < 100)
            {
                for (int i = k + 1; i <= n; i++)
                {
                    sum *= i;
                }
            }
            else
                {
                Console.Write("ERROR!");
                }
            Console.WriteLine(sum);
            }
        }
