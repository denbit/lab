using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiAD
{
    class InsertSecond : ISort
    {
        public InsertSecond()
        {
          //  this.SComparator = this.less;
        }
        public delegate bool op(int a, int b);
        public op SComparator;
        public int[] sort(int[] IntArray)
        {
            for (int cur = 1; cur < IntArray.Length; cur++)
            {
                int currentElement = IntArray[cur], previos;
                for (previos = (cur - 1); previos >= 0 && SComparator(IntArray[previos], currentElement); previos--)
                {
                    IntArray[previos + 1] = IntArray[previos];
                }
                IntArray[previos + 1] = currentElement;
            }
            return IntArray;
        }
        public bool great(int a, int b) => a > b;
        public bool less(int a, int b) => a < b;
    }
}
