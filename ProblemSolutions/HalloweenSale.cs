namespace HalloweenSale
{
    internal class HalloweenSale
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int p = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            int m = Convert.ToInt32(firstMultipleInput[2]);

            int s = Convert.ToInt32(firstMultipleInput[3]);

            int answer = howManyGames(p, d, m, s);

            Console.WriteLine(answer);
        }
        public static int howManyGames(int p, int d, int m, int s)
        {
            int control = p;
            int gameCount = 0;
            while (s > 0)
            {
                if (s - control >= 0)
                {
                    s -= control;
                    control = control - d > m ? control - d : m;                    
                    gameCount++;
                }
                else
                {
                    break;
                }
            }
            return gameCount;

        }

    }
}