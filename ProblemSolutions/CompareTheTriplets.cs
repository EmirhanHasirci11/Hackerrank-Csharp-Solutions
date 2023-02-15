namespace CompareTheTriplets
{
    internal class CompareTheTriplets
    {
        static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();
            compareTriplets(a, b).ForEach(x => Console.Write(x + " "));
        }
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int alice = 0; int bob = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i]) alice++;
                else if (a[i] < b[i]) bob++;
                else continue;
            }
            return new List<int> { alice, bob };
        }
    }
}