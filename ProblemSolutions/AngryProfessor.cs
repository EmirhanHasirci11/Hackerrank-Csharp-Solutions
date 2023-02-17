using System.IO;

namespace AngryProfessor
{
    internal class AngryProfessor
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int n = Convert.ToInt32(firstMultipleInput[0]);

                int k = Convert.ToInt32(firstMultipleInput[1]);

                List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

                string result = angryProfessor(k, a);

                Console.WriteLine(result);

            }

        }
        public static string angryProfessor(int k, List<int> a)
        {           
            return a.RemoveAll(x => x <= 0) >= k ? "NO" : "YES";

        }
    }
}