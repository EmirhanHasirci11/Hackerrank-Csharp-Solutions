namespace _2DArray_DS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>();
            for (int i = 0; i < 6; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }
            int result = hourglassSum(arr);
            Console.WriteLine(result);
        }
        public static int hourglassSum(List<List<int>> arr)
        {
            int sum = Int32.MinValue;
            for(int i=0;i<=3;i++)
            {
                int temp = 0;
                for(int j = 2; j < 6; j++)
                {
                    temp = arr[i][j] + arr[i][j - 1] + arr[i][j - 2];
                    temp += arr[i + 1][j - 1];
                    temp += arr[i + 2][j] + arr[i + 2][j - 1] + arr[i + 2][j - 2];
                    sum = Math.Max(sum, temp);
                }
            }
            return sum;
        }
    }
}