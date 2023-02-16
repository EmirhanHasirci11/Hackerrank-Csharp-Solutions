using System.Data;

namespace MigratoryBirds
{
    internal class MigratoryBirds
    {
        static void Main(string[] args)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = migratoryBirds(arr);

            Console.WriteLine(result);
        }
        public static int migratoryBirds(List<int> arr)
        {
            int[] counts = new int[6];
            arr.ForEach(x =>
            {
                counts[x]++;
            });
            int typeCount = counts[1];
            int mostType = 1;
            for (int i = 2; i < 6; i++)
            {
                if (counts[i]>typeCount)
                {
                    typeCount = counts[i];
                    mostType = i;
                }
            }
            return mostType;            
        }

    }
}