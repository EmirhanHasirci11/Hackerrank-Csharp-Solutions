namespace RunningTimeOfAlgorithms
{
    internal class RunningTimeOfAlgorithms
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = runningTime(arr);
            Console.WriteLine(result);
        }
        public static int runningTime(List<int> arr)
        {
            int shiftCount = 0;
            for (int i = 1; i < arr.Count; i++)
            {
                int key = arr[i];
                int indexer = i - 1;
                while (indexer >= 0 && arr[indexer] > key)
                {
                    arr[indexer + 1] = arr[indexer];
                    indexer--;
                    shiftCount++;
                }
                arr[indexer + 1] = key;
            }
           return shiftCount;
        }

    }
}