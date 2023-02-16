namespace CountingValleys
{
    internal class CountingValleys
    {
        static void Main(string[] args)
        {
            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = countingValleys(steps, path);
            Console.WriteLine(result);
        }
        public static int countingValleys(int steps, string path)
        {
            int level = 0;
            int previousLevel;
            int valleyCount = 0;
            for (int i = 0; i < steps; i++)
            {
                previousLevel = level;
                level += path[i] == 'U' ? 1 : -1;
                valleyCount += level == 0 && previousLevel == -1 ? 1 : 0;

            }
            return valleyCount;
        }
    }
}