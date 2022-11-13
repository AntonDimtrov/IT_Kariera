using System;

namespace PhoenixGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "ReadMe")
            {
                bool printYes = true;
                if (input.Contains('_') || input.Contains("\t")) printYes = false;
                if (printYes)
                {
                    string[] phrases = input.Split('.');
                    foreach(string phrase in phrases)
                    {
                        if (phrase.Length != 3)
                        {
                            printYes = false;
                            break;
                        }
                    }
                }

                if (printYes)
                {
                    char[] cArray = input.ToCharArray();
                    string reverse = String.Empty;
                    for (int i = cArray.Length - 1; i > -1; i--)
                    {
                        reverse += cArray[i];
                    }
                    if (reverse != input) printYes = false;
                }
                Console.WriteLine(printYes == true ? "YES" : "NO");
                input = Console.ReadLine();
            }
            

        }
    }
}
