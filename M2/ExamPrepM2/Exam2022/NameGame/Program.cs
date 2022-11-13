using System;

namespace NameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string bestName = "";
            int bestNameValue = 0;
            while (input != "END OF GAME")
            {
                int nameValue = 22;

                if (input.Length >= 7) nameValue += 11;
                if (input[input.Length - 1] == 'a') nameValue += 10;
                if (input[input.Length - 1] == 'v') nameValue += 13;
                if (nameValue > bestNameValue)
                {
                    bestName = input;
                    bestNameValue = nameValue;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Winner is name: {bestName}\nPoints: {bestNameValue}");
        }
    }
}
