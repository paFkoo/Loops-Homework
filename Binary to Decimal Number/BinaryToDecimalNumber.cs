using System;
    class BinaryToDecimalNumber
    {
        static void Main()
        {
            /*Using loops write a program that converts a binary integer number to its decimal form.
             * The input is entered as string. The output should be a variable of type long.
             * Do not use the built-in .NET functionality.*/
            Console.Write("Enter a binary number :");
            string bNumber = Console.ReadLine();

            long dNumber = 0;
            int powa = 1;
            for (int i = bNumber.Length - 1; i >= 0; i--)
            {
                int sign = bNumber[i] - 48;
                if (sign == 1)
                {
                    dNumber += sign * powa;
                }
                powa *= 2;
            }
            Console.WriteLine(dNumber);
        }
    }
