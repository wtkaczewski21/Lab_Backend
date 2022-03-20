using System;

namespace LocalAndGlobalTime
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string localDate = DateTime.Now.ToString("HH:mm:ss");
            string utcDate = DateTime.UtcNow.ToString("HH:mm:ss");
            Console.WriteLine(localDate);
            Console.WriteLine(utcDate);
        }
    }
}
