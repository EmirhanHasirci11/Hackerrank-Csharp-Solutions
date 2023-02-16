namespace SalesbyMatch
{
    internal class SalesbyMatch
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = sockMerchant(n, ar);
            Console.WriteLine(result);
        }
        public static int sockMerchant(int n, List<int> ar)
        {
            int pairs = 0;
            Dictionary<int,int> keyValuePairs= new Dictionary<int,int>();
            ar.ForEach(arTemp =>
            {
                if (!keyValuePairs.ContainsKey(arTemp))
                {
                    keyValuePairs.Add(arTemp, 1);
                }
                else
                {
                    keyValuePairs[arTemp]++;
                }
            });
            foreach(var item in keyValuePairs.Values)
            {
                if (item>1)
                {
                    int temp = item;
                    if (item % 2 != 0)
                    {
                        temp--;
                    }
                    while (temp != 0) {
                        pairs++;
                        temp -= 2;
                    }
                   
                }
            }
            return pairs;
        }
    }
}