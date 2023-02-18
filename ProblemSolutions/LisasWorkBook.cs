namespace LisasWorkBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = workbook(n, k, arr);

            Console.WriteLine(result);
        }
        public static int workbook(int n, int k, List<int> arr)
        {
            int pageCount = 1;
            int speacialCount = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= arr[i]; j++)
                {
                    if (pageCount == j)
                    {
                        speacialCount++;
                    }
                    if (j % k == 0)
                    {
                        pageCount++;
                    }
                    else if (j == arr[i])
                    {
                        pageCount++;
                    }
                }
            }
            return speacialCount;

        }
    }
}