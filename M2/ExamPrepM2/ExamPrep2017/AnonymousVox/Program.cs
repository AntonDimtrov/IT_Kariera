using System;
using System.Linq;

namespace AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            string encodedText = Console.ReadLine();
            string[] values = Console.ReadLine().Replace("{", "").Split('}').Where(x => x != "").ToArray();
            int x = 0; 
            int startIndex = 0, endIndex =-1; 
            string word = "", middle = "";
            int charsBeforeStart = 0;

            while (endIndex + word.Length + charsBeforeStart < encodedText.Length&&x<values.Length)
            {

                for (int i = endIndex+word.Length+1; i < encodedText.Length; i++)
                {

                    if (encodedText[i] != '_')
                    {
                        endIndex = encodedText.LastIndexOf(encodedText[i]);
                        if (i != endIndex)
                        {
                            startIndex = i;
                            break;
                        }
                        else charsBeforeStart++;
                    }
                }
                /*Console.WriteLine(startIndex);
                Console.WriteLine(endIndex);*/
                word = "";


                for (int s = startIndex, e = endIndex; s < endIndex && e < encodedText.Length; s++, e++)
                {
                    if (encodedText[s] == encodedText[e])
                    {
                        word += encodedText[s];
                    }
                    else break;
                }
                /*Console.WriteLine(word);
                middle = encodedText.Substring(startIndex + word.Length, endIndex - (startIndex + word.Length));
                Console.WriteLine(middle);*/
                encodedText = encodedText.Remove(startIndex + word.Length, endIndex - (startIndex + word.Length));
                encodedText = encodedText.Insert(startIndex + word.Length, values[x]);/*
                Console.WriteLine(encodedText);*/
                x++;
            }
            Console.WriteLine(encodedText);
        }
    }
}
