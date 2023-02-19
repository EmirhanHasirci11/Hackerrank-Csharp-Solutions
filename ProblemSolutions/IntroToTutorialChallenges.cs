namespace IntroToTutorialChallenges
{
    internal class IntroToTutorialChallenges
    {
        static void Main(string[] args)
        {
            int V = Convert.ToInt32(Console.ReadLine().Trim());

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = introTutorial(V, arr);
            Console.WriteLine(result);

        }
         public static int introTutorial(int V, List<int> arr)
        {
            return arr.IndexOf(V);
        }
    }
}