namespace SubarrayDivision
{
    internal class SubarrayDivision
    {


        static void Main(string[] args)
        {


            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            int result = SubarrayDivision.birthday(s, d, m);

            Console.WriteLine(result);
        }
        public static int birthday(List<int> s, int d, int m)
        {
            List<List<int>> listOfList = new List<List<int>>();
            for (int i = 0; i <= s.Count - m; i++)
            {
                List<int> temp = new List<int>();
                for (int j = i; j < i + m; j++)
                {
                    temp.Add(s[j]);
                }
                int sum = 0;
                temp.ForEach(x =>
                {
                    sum += x;
                });
                if (sum == d)
                {
                    listOfList.Add(temp);
                }
            }
            return listOfList.Count;
        }
    }
}