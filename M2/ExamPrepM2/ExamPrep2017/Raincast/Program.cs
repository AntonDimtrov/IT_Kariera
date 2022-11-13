using System;
using System.Collections.Generic;

namespace Raincast
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string type = "", source = "", forecast = "";
            bool t = false, s = false, f = false;
            List<string> messages = new List<string>();

            while (input != "Davai Emo")
            {
                string typeOfInput = input.Split(':')[0];
                string inputData = "";
                if (input.Contains(':')) { inputData = input.Split(':')[1]; }
                switch (typeOfInput)
                {
                    case "Type":
                        if (t == false && s == false && f == false)
                        {
                            inputData = inputData.Replace(" ", "");
                            if (inputData == "Danger" || inputData == "Warning" || inputData == "Normal")
                            {
                                type = inputData;
                                t = true;
                            }

                        }
                        break;
                    case "Source":
                        if (t == true && s == false && f == false)
                        {
                            source = inputData;
                            s = true;
                        }
                        break;
                    case "Forecast":
                        if (t == true && s == true && f == false)
                        {
                            inputData = inputData.Replace("!", "").Replace(".", "").Replace(",", "").Replace("?", "");
                            if (inputData.Replace(" ", "") != "")
                            {
                                forecast = inputData;
                                f = true;
                            }
                        }
                        break;
                    default: break;
                }
                if (t && s && f)
                {
                    messages.Add($"({type}){forecast} ~{source}");
                    t = false;
                    s = false;
                    f = false;
                }

                input = Console.ReadLine();
            }
            Console.Write(string.Join("\n", messages));

        }
    }
}
