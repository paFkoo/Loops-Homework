﻿using System;
using System.Text;
    class DecimalToHexadecimalNumber
    {
        static void Main()
        {
            /*Using loops write a program that converts an integer number to its hexadecimal representation.
             * The input is entered as long. The output should be a variable of type string.
             * Do not use the built-in .NET functionality.*/
            Console.WriteLine("Enter an integer number :");
            long dNumber = long.Parse(Console.ReadLine());

            StringBuilder bNumber = new StringBuilder();
            while (dNumber > 0)
            {
                int i = 0;
                char hexValue = '0';
                long remainder = dNumber % 16;
                if (remainder > 9)
                {
                    switch (remainder)
                    {
                        case 10: hexValue = 'A';
                            break;
                        case 11: hexValue = 'B';
                            break;
                        case 12: hexValue = 'C';
                            break;
                        case 13: hexValue = 'D';
                            break;
                        case 14: hexValue = 'E';
                            break;
                        case 15: hexValue = 'F';
                            break;
                        default: Console.WriteLine("Fail");
                            break;
                    }
                    bNumber.Insert(i, hexValue);
                }
                else
                {
                    bNumber.Insert(i, remainder);
                }
                dNumber /= 16;
                i++;
            }
            Console.WriteLine(bNumber);
        }
    }

