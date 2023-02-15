namespace AppleAndOrange
{
    internal class AppleAndOrange
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int s = Convert.ToInt32(firstMultipleInput[0]);

            int t = Convert.ToInt32(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int a = Convert.ToInt32(secondMultipleInput[0]);

            int b = Convert.ToInt32(secondMultipleInput[1]);

            string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int m = Convert.ToInt32(thirdMultipleInput[0]);

            int n = Convert.ToInt32(thirdMultipleInput[1]);

            List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

            List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int appleCount = 0;
            int orangeCount = 0;
            apples.ForEach(x =>
            {
                appleCount += a + x >= s && a + x <= t ? 1 : 0;
            });
            oranges.ForEach(x =>
            {
                orangeCount += b + x >= s && b + x <= t ? 1 : 0;
            });
            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);
        }
    }
}