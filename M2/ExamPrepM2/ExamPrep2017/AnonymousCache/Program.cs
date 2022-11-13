using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousCache
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> cache = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> bankAccounts = new Dictionary<string, Dictionary<string, int>>();

            while (input != "thetinggoesskrra")
            {
                string[] inpArgs = input.Split(' ').Where(x => x != "->").Where(x => x != "|").ToArray();
                if (inpArgs.Length > 1)
                {
                    string dataKey = inpArgs[0];
                    int dataSize = int.Parse(inpArgs[1]);
                    string dataSet = inpArgs[2];
                    if (bankAccounts.ContainsKey(dataSet))
                    {
                        if (bankAccounts[dataSet].ContainsKey(dataKey))
                        {
                            bankAccounts[dataSet][dataKey] += dataSize;
                        }
                        else
                        {
                            bankAccounts[dataSet].Add(dataKey, dataSize);
                        }

                    }
                    else
                    {
                        if (!cache.ContainsKey(dataSet))
                        {
                            cache.Add(dataSet, new Dictionary<string, int>());
                        }
                        cache[dataSet].Add(dataKey, dataSize);
                    }

                }
                else
                {
                    string dataSet = inpArgs[0];
                    if (!bankAccounts.ContainsKey(dataSet))
                    {
                        bankAccounts.Add(dataSet, new Dictionary<string, int>());
                        if (cache.ContainsKey(dataSet))
                        {
                            foreach (var pair in cache[dataSet])
                            {
                                bankAccounts[dataSet].Add(pair.Key, pair.Value);
                            }
                        }
                    }

                }
                input = Console.ReadLine();
            }
            if (bankAccounts.Count != 0)
            {
                
                ulong maxSum = 0;
                string maxDataSet="";
                foreach(var dataSet in bankAccounts)
                {
                    ulong sum = 0;
                    foreach (var bankAccount in dataSet.Value)
                    {
                        sum += (ulong)bankAccount.Value;
                    }
                    if (sum > maxSum) { maxSum = sum; maxDataSet = dataSet.Key; }
                }
                Console.WriteLine($"Data Set: {maxDataSet}, Total Size: {maxSum}");
                foreach(var account in bankAccounts[maxDataSet].Keys)
                {
                    Console.WriteLine($"$.{account}");
                }
            }
        }
    }
}
