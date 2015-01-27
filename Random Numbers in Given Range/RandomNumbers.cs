using System;
    class RandomNumbers
    {
        static void Main()
        {
            /*Write a program that enters 3 integers n, min and max (min != max) 
             * and prints n random numbers in the range [min...max].*/
            Console.WriteLine("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter min: ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter max: ");
            int max = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", rnd.Next(min, max + 1));
            }
        }
    }
