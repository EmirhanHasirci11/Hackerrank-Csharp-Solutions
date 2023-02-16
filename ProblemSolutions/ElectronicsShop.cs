namespace ElectronicsShop
{
    internal class ElectronicsShop
    {
        static void Main(string[] args)
        {
            string[] bnm = Console.ReadLine().Split(' ');

            int b = Convert.ToInt32(bnm[0]);

            int n = Convert.ToInt32(bnm[1]);

            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
            ;

            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
            ;

            int moneySpent = getMoneySpent(keyboards, drives, b);

            Console.WriteLine(moneySpent);
        }
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int max = 0;
            Array.Sort(keyboards);
            Array.Sort(drives);
            if (keyboards[0] + drives[0] > b)
            {
                return -1;
            }
            else
            {
                foreach(var keyboard in keyboards)
                {
                    foreach (var drive in drives)
                    {
                        max =drive+keyboard<=b ?Math.Max(max, keyboard + drive):max;
                    }
                }
            }
            return max;

        }
    }
}