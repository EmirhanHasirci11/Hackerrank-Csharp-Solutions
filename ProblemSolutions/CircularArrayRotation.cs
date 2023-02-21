namespace CircularArrayRotation
{
    internal class CircularArrayRotation
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            int q = Convert.ToInt32(firstMultipleInput[2]);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> queries = new List<int>();

            for (int i = 0; i < q; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine().Trim());
                queries.Add(queriesItem);
            }

            circularArrayRotation(a, k, queries).ForEach(x => Console.WriteLine(x));

        }
        public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
        {
            List<int> result = new List<int>();
            int[] shiftedArr = new int[a.Count];
            for (int i = 0; i < a.Count; i++)
            {
                shiftedArr[(i + k) % a.Count] = a[i];
            }
            queries.ForEach(x => result.Add(shiftedArr[x]));

            return result;

        }
    }
}