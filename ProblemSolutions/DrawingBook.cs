namespace DrawingBook
{
    internal class DrawingBook
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());
            int p = Convert.ToInt32(Console.ReadLine().Trim());
            int result = pageCount(n, p);
            Console.WriteLine(result);


        }

        public static int pageCount(int n, int p)
        {
            return Math.Min(p/2, n/2-p/2);            
        }
    }
}