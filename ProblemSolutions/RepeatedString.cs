namespace RepeatedString
{
    internal class RepeatedString
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            long n = Convert.ToInt64(Console.ReadLine().Trim());
            long result = repeatedString(s, n);
            Console.WriteLine(result);
        }
        public static long repeatedString(string s, long n)
        {
            int count = s.Where(x => x == 'a').Count();           
            long remaining = n % s.Length;
            string str = s.Substring(0,(int)remaining);
            return n%s.Length==0? count * (n / s.Length) : str.Where(x=>x=='a').Count()+((n-remaining)/s.Length)*count;
        }

    }
}