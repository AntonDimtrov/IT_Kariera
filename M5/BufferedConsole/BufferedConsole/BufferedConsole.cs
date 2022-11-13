using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BufferedConsole
{
    class BufferedConsole : IDisposable
    {
        private StreamWriter writer;
        private StreamWriter sw;
        private char[] buffer;
        private int index = 0;

        public BufferedConsole()
        {
            this.writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            this.buffer = new char[50];
        }

        public void Dispose()
        {
            writer.Write(buffer);
            writer.Close();
        }

        public void Write(string s)
        {
            writer.Write(buffer);
            writer.Close();

            for (int i = 0; i < s.Length; i++)
            {
                if (index == 50)
                {
                    index = 0;
                    Console.WriteLine(string.Join("", buffer));
                }
                buffer[index++] = (char)s[i];
            }
        }


    }
}
