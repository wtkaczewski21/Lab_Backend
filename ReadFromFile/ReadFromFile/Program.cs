using System;
using System.IO;
using System.Reflection;

namespace ReadFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TextFile.txt");
            string text = File.ReadAllText(path);

            Console.WriteLine(text);
        }
    }
}
