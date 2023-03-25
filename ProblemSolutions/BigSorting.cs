using System.IO;
using System.Numerics;

namespace BigSorting
{
    internal class BigSorting
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> unsorted = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string unsortedItem = Console.ReadLine();
                unsorted.Add(unsortedItem);
            }
            bigSorting(unsorted).ForEach(x=>Console.WriteLine(x));

           

        }
        public static List<string> bigSorting(List<string> unsorted)
        {
            unsorted = unsorted.OrderBy(x => x).ToList();
            unsorted = unsorted.OrderBy(x => x.Length).ToList();
            return unsorted;
        }
    }
}