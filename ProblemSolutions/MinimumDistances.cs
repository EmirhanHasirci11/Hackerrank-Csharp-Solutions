namespace MinimumDistances
{
    internal class MinimumDistances
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result =  minimumDistances(a);

            Console.WriteLine(result);
        }
        public static int minimumDistances(List<int> a)
        {
            List<int> distances= new();
            int lenght = a.Count;
            for(int i = 0; i < lenght-1; i++)
            {
                for(int j = i + 1; j < lenght; j++)
                {
                    if (a[i] == a[j])
                    {
                        distances.Add(Math.Abs(i-j));
                        break;
                    }
                }
            }
            return distances.Count==0?-1:distances.Min();
        }
    }
}