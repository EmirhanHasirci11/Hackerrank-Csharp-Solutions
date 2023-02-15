namespace SimpleArraySum
{
    internal class SimpleArraySum
    {
        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
            int result = simpleArraySum(ar);      
            Console.WriteLine(result);
        }
        public static int simpleArraySum(List<int> ar)
        {
            return ar.Sum();
        }

    }
}