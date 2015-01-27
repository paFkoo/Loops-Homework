﻿using System;
using System.Text;
    class DecimalToBinaryNumber
    {
        static void Main()
        {
            /*Using loops write a program that converts an integer number to its binary representation.
             * The input is entered as long. The output should be a variable of type string.
             * Do not use the built-in .NET functionality.*/
            Console.Write("Enter an integer number: ");
            long dNumber = long.Parse(Console.ReadLine());
            long remainder;
            StringBuilder bNumber = new StringBuilder();

            while (dNumber > 0)
            {
                int i = 0;
                remainder = dNumber % 2;
                bNumber.Insert(i, remainder);

                dNumber /= 2;
                i++;
            }
            Console.WriteLine(bNumber);
        }
    }
