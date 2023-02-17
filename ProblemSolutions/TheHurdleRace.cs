namespace TheHurdleRace
{
    internal class TheHurdleRace
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> height = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(heightTemp => Convert.ToInt32(heightTemp)).ToList();

            int result = hurdleRace(k, height);
            Console.WriteLine(result);
        }
        public static int hurdleRace(int k, List<int> height)
        {
            int cont = height.OrderByDescending(x => x).First();
            return k>cont?0:cont-k;
        }
    }
}