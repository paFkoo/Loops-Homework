using System;
    class HexadecimalToDecimalNumber
    {
        static void Main()
        {
            /*Using loops write a program that converts a hexadecimal integer number to its decimal form.
             * The input is entered as string. The output should be a variable of type long.
             * Do not use the built-in .NET functionality.*/
            Console.WriteLine("Enter a hexadecimal integer number :");
            string hNumber = Console.ReadLine();
            long dNumber = 0;
            long powa = 1;

            for (int i = hNumber.Length - 1; i >= 0; i--)
            {
                int sign;
                switch (hNumber[i])
                {
                    case 'A': sign = 10;
                        break;
                    case 'B': sign = 11;
                        break;
                    case 'C': sign = 12;
                        break;
                    case 'D': sign = 13;
                        break;
                    case 'E': sign = 14;
                        break;
                    case 'F': sign = 15;
                        break;
                    default: sign = hNumber[i] - 48;
                        break;
                }
                dNumber += sign * powa;
                powa *= 16;
            }
            Console.WriteLine(dNumber);
        }
    }
