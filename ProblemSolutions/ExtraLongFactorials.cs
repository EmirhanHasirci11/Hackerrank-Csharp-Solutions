using System.Numerics;

namespace ExtraLongFactorials
{
    internal class ExtraLongFactorials
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine(extraLongFactorials(n));
        }
        public static BigInteger extraLongFactorials(int n)
        {            
            return n == 1 ? 1 : n * extraLongFactorials(n - 1);
        }
    }
}