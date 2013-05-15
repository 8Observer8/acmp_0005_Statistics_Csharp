using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using acmp_0005_Statistics_Csharp;

namespace UsageStatistics
{
    class Program
    {
        public static void printArr(ref List<int> list)
        {
            foreach (int val in list)
            {
                System.Console.WriteLine(val);
            }
        }

        static void Main(string[] args)
        {
            Statictics s = new Statictics();
            List<int> inputArr = new List<int>(new int[] { 4, 16, 19, 31, 2 });

            List<int> outEvenArr = new List<int>();
            List<int> outOddArr = new List<int>();

            bool isEvenGreater = s.statistics(ref inputArr, ref outEvenArr, ref outOddArr);

            System.Console.WriteLine("inputArr:");
            printArr(ref inputArr);

            System.Console.WriteLine("\noutEvenArr:");
            printArr(ref outEvenArr);

            System.Console.WriteLine("\noutEvenArr:");
            printArr(ref outEvenArr);
        }
    }
}
