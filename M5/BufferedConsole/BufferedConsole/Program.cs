using System;
using System.IO;

namespace BufferedConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BufferedConsole bufferedConsole = new BufferedConsole();
            using (bufferedConsole)
            {
                bufferedConsole.Write(new string('a', 20));
                bufferedConsole.Write(new string('b', 20));
                bufferedConsole.Write(new string('c', 20));
                bufferedConsole.Dispose();

            }
            /*
            try
            {
                bufferedConsole.Write(new string('o', 49));
                bufferedConsole.Write(new string('x', 2));

            }

            finally
            {
                ((IDisposable)bufferedConsole).Dispose();
            }*/
        }
    }
}
