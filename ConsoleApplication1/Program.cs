using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "hello there!";
            int bufferSize = 1024;
            byte[] buffer = new byte[bufferSize];
            for (int i = 0; i < inputString.Length; i++)
            {
                buffer[i] = Encoding.UTF8.GetBytes(inputString)[i];
            }
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Encoding.UTF8.GetString(buffer));
            string data = stringBuilder.ToString();
            
            char ch = data[1022];
            int index = data.IndexOf(ch);
            data = data.Substring(0, 12);
            Console.WriteLine(data);
            Console.WriteLine(data.Length);
            
            Console.ReadLine();
        }
    }
}
