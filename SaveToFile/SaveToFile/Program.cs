using System;
using System.IO;

namespace SaveToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            File.WriteAllText("TextFile.txt", text);
        }
    }
}
