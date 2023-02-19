namespace SparseArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stringsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> strings = new List<string>();

            for (int i = 0; i < stringsCount; i++)
            {
                string stringsItem = Console.ReadLine();
                strings.Add(stringsItem);
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> queries = new List<string>();

            for (int i = 0; i < queriesCount; i++)
            {
                string queriesItem = Console.ReadLine();
                queries.Add(queriesItem);
            }

            int[] res = matchingStrings(strings, queries);
            foreach (int s in res)
            {
                Console.WriteLine(s);
            }
        }
        public static int[] matchingStrings(List<string> strings, List<string> queries)
        {
            int[] output = new int[queries.Count];
            foreach (string path in strings)
            {
                for (int i = 0; i < queries.Count; i++)
                {
                    if (queries[i] == path)
                    {
                        output[i]++;
                    }
                }
            }

            return output;
        }
    }
}