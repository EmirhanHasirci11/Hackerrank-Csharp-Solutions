namespace SaveThePrisoner
{
    internal class SaveThePrisoner
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int n = Convert.ToInt32(firstMultipleInput[0]);

                int m = Convert.ToInt32(firstMultipleInput[1]);

                int s = Convert.ToInt32(firstMultipleInput[2]);

                int result = saveThePrisoner(n, m, s);

                Console.WriteLine(result);
            }

        }
        public static int saveThePrisoner(int n, int m, int s)
        {
            return (m + s - 1) % n==0?n: (m + s - 1) % n;
        }
    }
}