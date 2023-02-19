namespace CamelCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int result = camelcase(s);
            
            Console.WriteLine(result);
        }
        public static int camelcase(string s)
        {
            int count = 1;
            foreach (char c in s)
            {
                count += Char.IsUpper(c) == true ? 1 : 0;
            }
            return count;
        }
    }
}