using System;

namespace WordGuessGameV2
{
    class Program
    {
        static void Main()
        {
            Boolean hint1 = true;
            Boolean hint2 = true;
            Random random = new Random();
            // VARS
            int MaxGuess = 5;
            int TryCount = 0;
            string[] Words = { "HELLO", "WELCOME", "LIKE", "HATE", "WORLD", "BUY", "SELL", "MEAL", "RESCUE", "VESSEL" };
            string Word = Words[random.Next(0, 11)];
            // GAME
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome To Word Guess Game\n");
            Console.WriteLine("Guess The Word (Write With Caps)\n");
            Console.WriteLine("The Word Is Starting With : " + Word[0] + "\n\n");
            while (TryCount < MaxGuess || TryCount == MaxGuess)
            {
                if (TryCount > 2) { if (hint1 == true) { Console.WriteLine("hint : " + Word[1]); hint1 = false; } }
                if (TryCount > 4) { if (hint2 == true) { Console.WriteLine("hint : " + Word[2]); hint2 = false; } }
                string Guess = Console.ReadLine();
                if (Guess != Word)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("False Word Try Again...");
                    TryCount++;
                }
                if (Guess == Word)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You Win :)");
                    break;
                }
            }
            if (TryCount > MaxGuess)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You Lose :(");
            }
            Console.ReadKey();
        }
    }
}
