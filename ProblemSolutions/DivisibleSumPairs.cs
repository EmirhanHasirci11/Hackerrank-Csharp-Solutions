namespace DivisibleSumPairs
{
    internal class DivisibleSumPairs
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = divisibleSumPairs(n, k, ar);

            Console.WriteLine(result);
        }
        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j <n ; j++)
                {
                    count += (ar[i] + ar[j])%k == 0 ? 1: 0;
                }
            }
            return count;
        }
    }
}