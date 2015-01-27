using System;
    class Calculate
    {
        static void Main()
        {
            /*Write a program that, for a given two integer numbers n and x, calculates the sum 
             * S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
             * Use only one loop. Print the result with 5 digits after the decimal point.*/
            Console.Write("Enter the n integer: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the x integer: ");
            int x = int.Parse(Console.ReadLine());
            decimal sum = 1;
            decimal factorial = 1;
            decimal xPowerN = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                xPowerN *= x;
                sum += (factorial / xPowerN);
            }
            Console.WriteLine("{0:F5}", sum);
        }
    }
