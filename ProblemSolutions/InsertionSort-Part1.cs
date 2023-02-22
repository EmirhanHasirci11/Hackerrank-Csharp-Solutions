namespace InsertionSort_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            insertionSort1(n, arr);
        }
        public static void insertionSort1(int n, List<int> arr)
        {
            int key = arr[arr.Count - 1];
            int indexer = arr.Count - 2;
            while (indexer >= 0 && arr[indexer] > key)
            {
                arr[indexer + 1] = arr[indexer];
                indexer--;
                arr.ForEach(x=>Console.Write(x+" "));
                Console.WriteLine();
            }
            arr[indexer + 1] = key;
            arr.ForEach(x => Console.Write(x+""));
        }
    }
}