namespace NumberLineJumps
{
    internal class NumberLineJumps
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int x1 = Convert.ToInt32(firstMultipleInput[0]);

            int v1 = Convert.ToInt32(firstMultipleInput[1]);

            int x2 = Convert.ToInt32(firstMultipleInput[2]);

            int v2 = Convert.ToInt32(firstMultipleInput[3]);

            string result = kangaroo(x1, v1, x2, v2);
            Console.WriteLine(result);
        }
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            return v1 > v2 && (x2 - x1) % (v1 - v2) == 0 ? "YES" : "NO";
        }

    }
}