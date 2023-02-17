namespace ViralAdvertising
{
    internal class ViralAdvertising
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            int result =viralAdvertising(n);
            Console.WriteLine(result);
        }
        public static int viralAdvertising(int n)
        {
            int shared = 5;
            int liked = shared/2;
            int cumulative = liked;
            for (int i = 1; i < n; i++)
            {
                shared = liked * 3;
                liked = shared/2;
                cumulative += liked;
            }
            return cumulative;
        }

    }
}