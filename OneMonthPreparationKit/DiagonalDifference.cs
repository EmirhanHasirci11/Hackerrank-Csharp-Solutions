namespace DiagonalDifference
{
    internal class DiagonalDifference
    {
        static void Main(string[] args)
        {
            

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = DiagonalDifference.diagonalDifference(arr);
            Console.WriteLine(result);
        }
        public static int diagonalDifference(List<List<int>> arr)
        {
            int leftToRight = 0;
            int indexer = 0;
            int reverseIndexer = arr[0].Count-1;
            int rightToLeft= 0;
            arr.ForEach(arrTemp =>
            {
                leftToRight += arrTemp[indexer];
                indexer++;
                rightToLeft+= arrTemp[reverseIndexer];
                reverseIndexer--;
            });
            return Math.Abs(leftToRight - rightToLeft);
        }
    }
}