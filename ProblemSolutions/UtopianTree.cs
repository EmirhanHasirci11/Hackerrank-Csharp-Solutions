using System.IO;

namespace UtopianTree
{
    internal class UtopianTree
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                int result = utopianTree(n);

                Console.WriteLine(result);
            }
        }
        public static int utopianTree(int n)
        {
            int height = 1;
            for (int i = 1; i <=n; i++)
            {
                height = i % 2 == 0 ? height+1 : height * 2;
            }
            return height;
        }
    }
}