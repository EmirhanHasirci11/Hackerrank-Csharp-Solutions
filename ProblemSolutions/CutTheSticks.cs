namespace CutTheSticks
{
    internal class CutTheSticks
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            cutTheSticks(arr).ForEach(x => Console.WriteLine(x));

        }
        public static List<int> cutTheSticks(List<int> arr)
        {
            List<int> result = new List<int>();
            result.Add(arr.Count);
            while (arr.Sum() > 0)
            {
                int min = arr.Any(x => x > 0) == true ? arr.Where(x => x > 0).Min() : 0;
                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] <= 0) continue;
                    
                    arr[i] -= min;
                }
                result.Add(arr.Count - arr.Where(x => x <= 0).ToList().Count());
            }
            return result.SkipLast(1).ToList();

        }
    }
}