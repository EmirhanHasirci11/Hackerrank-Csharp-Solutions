namespace BreakingTheRecords
{
    internal class BreakingTheRecords
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

            breakingRecords(scores).ForEach(s => Console.Write(s + " "));


        }
        public static List<int> breakingRecords(List<int> scores)
        {
            int min = scores[0];
            int max = scores[0];
            int minCount = 0;
            int maxCount = 0;
            scores.ForEach(s =>
            {
                if (s < min)
                {
                    minCount++;
                    min = s;
                }
                else if (s > max)
                {
                    maxCount++;
                    max = s;
                }
            });
            return new List<int> { maxCount, minCount };
        }
    }
}