namespace InsertionSort_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            insertionSort2(n, arr);
        }
        public static void insertionSort2(int n, List<int> arr)
        {
            for (int i = 1; i < arr.Count; i++)
            {
                int key = arr[i];
                int indexer = i - 1;
                while (indexer >= 0 && arr[indexer] > key)
                {
                    arr[indexer + 1] = arr[indexer];
                    indexer--;

                }
                arr[indexer + 1] = key;
                arr.ForEach(x => Console.Write(x + " "));
                Console.WriteLine();
            }
        }
    }
}