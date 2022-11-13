using System;
using System.Numerics;

namespace AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            byte securityKey = byte.Parse(Console.ReadLine());
            var securityToken = new BigInteger(1);
            decimal totalLoss = 0;
            string names = "";
            for(int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string siteName = input[0];
                ulong siteVisits = ulong.Parse(input[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(input[2]);
                totalLoss += siteVisits * siteCommercialPricePerVisit;
                names += siteName + "\n";
                securityToken *= securityKey;
            }
            Console.Write(names);
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {securityToken}");
            
            
        }
    }
}
