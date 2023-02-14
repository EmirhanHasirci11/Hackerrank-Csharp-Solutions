namespace PermutationEquation
{
    internal class PermutationEquation
    {
        static void Main(string[] args)
        {
            ;

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> p = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(pTemp => Convert.ToInt32(pTemp)).ToList();

            List<int> result = PermutationEquation.permutationEquation(p);

            result.ForEach(x => Console.WriteLine(x));
        }
        public static List<int> permutationEquation(List<int> p)
        {
            List<int> result = new List<int>();
            for (int i = 1; i <= p.Count; i++)
            {
                int index1 = p.IndexOf(i) + 1;
                int index2 = p.IndexOf(index1) + 1;
                result.Add(index2);
            }
            return result;
        }
    }
}