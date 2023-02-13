namespace FlippingBits
{
    internal class FlippingBits
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                long n = Convert.ToInt64(Console.ReadLine().Trim());

                long result = FlippingBits.flippingBits(n);

                Console.WriteLine(result);
            }
        }

        public static long flippingBits(long n)
        {
            string temp = Convert.ToString(n, 2).PadLeft(32,'0');                       
            string str = string.Empty;
            temp.ToList().ForEach(x =>
            {
                if (x == '0')
                {
                    str += 1;
                }
                else
                {
                    str += 0;
                }
            });
            return Convert.ToInt64(str, 2);

        }

    }
}