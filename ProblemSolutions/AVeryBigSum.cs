namespace AVeryBigSum
{
    internal class AVeryBigSum
    {
        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

            long result = aVeryBigSum(ar);
            Console.WriteLine(result);
        }
        public static long aVeryBigSum(List<long> ar)
        {
            return ar.Sum();
        }
    }
}