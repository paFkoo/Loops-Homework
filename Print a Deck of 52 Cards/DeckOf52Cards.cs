using System;
    class DeckOf52Cards
    {
        static void Main()
        {
           /*Write a program that generates and prints all possible cards from a standard deck of 52 cards 
            * (without the jokers). The cards should be printed using the classical notation 
            * (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).The card faces should start from 2 to A.
            * Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
            * Use 2 nested for-loops and a switch-case statement.*/
            string a = "spades";
            string b = "hearts";
            string c = "diamonds";
            string d = "clubs";
            for (int p = 2; p < 11; p++)
            {
                Console.Write("{0} of {1} , {0} of {2} , {0} of {3} , {0} of {4}\n", p, a, b, c, d);
            }
                        
            for (int i = 11; i < 15; i++)
            {
                switch (i)
                {
                    case 14: Console.Write("A of {0} , A of {1} , A of {2} , A of {3}\n", a, b, c, d); break;
                    case 11: Console.Write("J of {0} , J of {1} , J of {2} , J of {3}\n", a, b, c, d); break;
                    case 12: Console.Write("Q of {0} , Q of {1} , Q of {2} , Q of {3}\n", a, b, c, d); break;
                    case 13: Console.Write("K of {0} , K of {1} , K of {2} , K of {3}\n", a, b, c, d); break;
                }
            }
                
                
            
        }
    }
