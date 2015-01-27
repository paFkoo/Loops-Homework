using System;
class MatrixOfNumbers
{
    static void Main()
    {
        /*Write a program that reads from the console a positive integer number n (1 = n = 20) 
         * and prints a matrix like in the examples below. Use two nested loops.*/
        Console.Write("Enter a positive integer number: ");
        int n = int.Parse(Console.ReadLine());
        if (n > 0 && n <= 20)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    Console.Write("{0,2} ", column + row);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("The number must be bigger than 0 and lesser than 21");
        }
    }
}

