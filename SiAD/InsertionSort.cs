using System;

namespace SiAD
{
    public class InsertionSort : ISort
    {
        public int[] sort(int[] IntArray)
        {
            for (int i = 1; i < IntArray.Length; i++)
            {
                var key = IntArray[i];
                int prev = i - 1;
              
                while (prev>=0 && IntArray[prev]>key)
                {
                    IntArray[prev + 1] = IntArray[prev];
                    prev--;
                }
 Console.WriteLine(key);
                IntArray[prev+1] = key;
            }

            return IntArray;
        }
    }
}