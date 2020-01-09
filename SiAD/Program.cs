using System;
using System.Linq;

namespace SiAD
{

  internal class Program
  {
    public static void Main(string[] args)
    {
      ISort algorithm = null;
      string algo="insertion";
      switch (algo)
      {
      case "insertion": algorithm = new InsertionSort();
        break;
      case "merge": algorithm = new InsertionSort();
        break;
       
      }

      if (algorithm != null)
      {
           var output = algorithm.sort(new int[]{2,5,1,76,2,9,56,124,4,5,8});
           Console.WriteLine(String.Join(",",output));
           
      }

    }
  }
}