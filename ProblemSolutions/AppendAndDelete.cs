namespace AppendAndDelete
{
    internal class AppendAndDelete
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string t = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine().Trim());

            string result = appendAndDelete(s, t, k);

            Console.WriteLine(result);
        }
        public static string appendAndDelete(string s, string t, int k)
        {
            int n = s.Length, m = t.Length, i = 0;

            if (k >= m + n) {  return "Yes"; }

            while (i < Math.Min(m, n) && s[i] == t[i]) i++;                        

            k -= m - i + n - i;
            return k >= 0 && k % 2 == 0 ? "Yes" : "No";


        }
    }
}