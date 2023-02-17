using System.IO;

namespace FindDigits
{
    internal class FindDigits
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                int result = findDigits(n);

                Console.WriteLine(result);
            }

        }
        public static int findDigits(int n)
        {
            string stringN = n.ToString();
            int count = 0;
            foreach (char c in stringN)
            {
                count += c != '0' && n % Convert.ToUInt16(c.ToString()) == 0 ? 1 : 0;
            }
            return count;
        }
    }
}