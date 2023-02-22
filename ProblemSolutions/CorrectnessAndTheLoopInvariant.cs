namespace CorrectnessAndTheLoopInvariant
{
    internal class CorrectnessAndTheLoopInvariant
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            int[] _ar = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
            insertionSort(_ar);
        }
        public static void insertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int indexer = i - 1;
                while (indexer >= 0 && arr[indexer] > key)
                {
                    arr[indexer + 1] = arr[indexer];
                    indexer--;

                }
                arr[indexer + 1] = key;
            }
            arr.ToList().ForEach(x => Console.Write(x + " "));
        }
    }
}