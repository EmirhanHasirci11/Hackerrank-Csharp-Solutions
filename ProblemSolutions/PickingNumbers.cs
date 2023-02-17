namespace PickingNumbers
{
    internal class PickingNumbers
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = pickingNumbers(a);

            Console.WriteLine(result);
        }
        public static int pickingNumbers(List<int> a)
        {
            a.Sort();
            int result = 0;        
            for (int i = 0; i < a.Count; i++)
            {
                int j = i;
                while (j < a.Count && a[j] - a[i] <= 1)
                    j++;               
                result = j - i + 1 > result ? j - i : result;
            }
            return result;
        }
    }
}