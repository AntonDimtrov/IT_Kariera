using System;

namespace WordGame_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            string bestWord = "";
            int bestWordValue = 0;
            while (input != "END OF GAME")
            {
                int wordValue = 0;
                foreach(char c in input)
                {
                    wordValue += c;
                }
                if (input[0].ToString() == input[0].ToString().ToUpper())wordValue += 15; 
                if (input.Length >= 10) wordValue += 30;
                if (input[input.Length - 1] == 't') wordValue += 20;
                if (wordValue > bestWordValue)
                {
                    bestWord = input;
                    bestWordValue = wordValue;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Winner is word: {bestWord}\nPoints: {bestWordValue}");
        }
    }
}
