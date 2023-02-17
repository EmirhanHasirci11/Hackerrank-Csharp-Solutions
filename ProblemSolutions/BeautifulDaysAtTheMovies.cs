namespace BeautifulDaysAtTheMovies
{
    internal class BeautifulDaysAtTheMovies
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int i = Convert.ToInt32(firstMultipleInput[0]);

            int j = Convert.ToInt32(firstMultipleInput[1]);

            int k = Convert.ToInt32(firstMultipleInput[2]);

            int result = beautifulDays(i, j, k);

            Console.WriteLine(result);

        }
        public static int beautifulDays(int i, int j, int k)
        {
            int result = 0;
            for (; i <= j; i++)
            {
                result += (i - reverseInt(i)) % k == 0 ? 1 : 0;
            }
            return result;
        }
        public static int reverseInt(int value)
        {
            string temp = value.ToString();
            string result = string.Empty;
            for (int i = 0; i < temp.Length; i++)
            {
                result = temp[i] + result;
            }
            return int.Parse(result);
        }
    }
}