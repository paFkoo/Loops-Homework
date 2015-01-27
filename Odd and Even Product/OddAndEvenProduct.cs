using System;
    class OddAndEvenProduct
    {
        static void Main()
        {
      /*u are given n integers (given in a single line, separated by a space).
   * Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
       * Elements are counted from 1 to n, so the first element is odd, the second is even, etc.*/
            Console.Write("Enter  5 numbers separated by  a space: ");
            string input = Console.ReadLine();
            string[] array = input.Split(' ');
            int oddProduct = 1;
            int evenProduct = 1;

            for (int i = 0; i < array.Length; i++)
            {
                int number = int.Parse(array[i]);
                if (i % 2 == 0 || i == 0)
                {
                    oddProduct *= number;
                }
                else
                {
                    evenProduct *= number;
                }
            }
            if (oddProduct == evenProduct)
            {
                Console.WriteLine("Product is equal.");
                Console.WriteLine("product = {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("Product is NOT equal.");
                Console.WriteLine("odd procuct = {0}", oddProduct);
                Console.WriteLine("even procuct = {0}", evenProduct);
            }          

        }
    }
