namespace RecursiveDigitSum
{
    internal class RecursiveDigitSum
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            string n = firstMultipleInput[0];

            int k = Convert.ToInt32(firstMultipleInput[1]);

            int result = superDigit(n, k);

            Console.WriteLine(result);
        }
        public static int superDigit(string n, int k)
        {
            long sum = 0;
            n.ToList().ForEach(x => sum += Convert.ToInt16(x.ToString()));           
            return n.Length == 1 ? Convert.ToInt32(n) : k != 0 ? superDigit((sum * k).ToString(), 0) : superDigit(sum.ToString(), 0);

        }

    }
}