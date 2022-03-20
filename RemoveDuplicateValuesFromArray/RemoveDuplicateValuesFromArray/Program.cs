using System;
using System.Collections.Generic;

namespace RemoveDuplicateValuesFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 3, 4, 5, 5, 5 };
            HashSet<int> newArr = new HashSet<int>(arr);
            int[] result = new int[newArr.Count];
            newArr.CopyTo(result);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }
    }
}
