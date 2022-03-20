using System;

namespace SplitToSeparateLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Tekst do rozbicia na osobne linie";

            string[] subs = text.Split(' ');

            int counter = 1;

            foreach (var sub in subs)
            {             
                Console.WriteLine(counter + " " + sub);
                counter++;
            }
        }
    }
}
