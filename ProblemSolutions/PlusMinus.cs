using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversionSolution
{
    public class PlusMinus
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            PlusMinus.plusMinus(arr);
        }
        public static void plusMinus(List<int> arr)
        {
            decimal negativeCount = 0;
            decimal positiveCount = 0;
            decimal zeroCount = 0;
            foreach (var indexer in arr)
            {

                if (indexer == 0)
                {
                    zeroCount++;
                }
                else if (indexer >= 1)
                {
                    positiveCount++;
                }
                else
                {
                    negativeCount++;
                }
            }
            Console.WriteLine(positiveCount / arr.Count);
            Console.WriteLine(negativeCount / arr.Count);
            Console.WriteLine(zeroCount / arr.Count);

        }


    }
}
