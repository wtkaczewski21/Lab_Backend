using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayListAndLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myAL = new ArrayList();
            myAL.Add(1);
            myAL.Add(2);
            myAL.Add(3);
            myAL.Add(4);
            myAL.Add(5);
            myAL.Add(6);
            myAL.Add(7);
            myAL.Add(8);
            myAL.Add(9);
            myAL.Add(10);

            for (int i = myAL.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    myAL.Remove(myAL[i]);
                }
            }
            foreach (var item in myAL)
            {
                Console.WriteLine(item);
            }
        }
    }
}
