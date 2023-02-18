namespace BetweenTwoSets
{
    internal class BetweenTwoSets
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

            int total = getTotalX(arr, brr);

            Console.WriteLine(total);
        }
        public static int getTotalX(List<int> a, List<int> b)
        {
            int begin = a.Max();
            int end = b.Min();
            int count = 0;
            for (; begin <= end; begin++)
            {
                if (a.Any(x => begin % x != 0)) continue;
                if (b.Any(x => x % begin != 0)) continue;
                count++;
            }
            return count;

        }
    }
}
