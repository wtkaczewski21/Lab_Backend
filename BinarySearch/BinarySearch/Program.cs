using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int searchIndex(int[] array, int value)
            {
                int index = 0;
                int limit = array.Length - 1;
                while (index <= limit)
                {
                    int point = (int)(Math.Ceiling((index + limit) / 2d));
                    int entry = array[point];
                    if (value > entry)
                    {
                        index = point + 1;
                        continue;
                    }
                    else if (value < entry)
                    {
                        limit = point - 1;
                        continue;
                    }
                    else
                        return point; // value == entry
                }
                return -1;
            }
            // Usage example:

            // for this implementation array must be sorted from smallest to biggest!
            int[] array = new int[] { 4, 5, 7, 11, 12, 15, 15, 21, 40, 45 };
            int index = searchIndex(array, 11); // we want to find index for 11

            Console.WriteLine(index); // 3
        }
    }
}
