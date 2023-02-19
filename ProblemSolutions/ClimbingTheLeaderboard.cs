using System;
using System.IO;

namespace ClimbingTheLeaderboard
{
    internal class ClimbingTheLeaderboard
    {
        static void Main(string[] args)
        {

            int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

            int playerCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

            climbingLeaderboard(ranked, player).ForEach(x => Console.WriteLine(x));
        }
        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            List<int> result = new List<int>();
            ranked = ranked.Distinct().ToList();
            int index = 0;
            for (int i = player.Count - 1; i >= 0; i--)
            {
                if (player[i] < ranked[ranked.Count - 1])
                {
                    result.Add(ranked.Count + 1);
                    continue;
                }
                for (int j = index; j < ranked.Count; j++)
                {
                    if (player[i] >= ranked[j])
                    {
                        result.Add(j + 1);
                        index = j;
                        break;
                    }
                }

            }
            return result.OrderByDescending(x=>x).ToList();



        }
    }
}