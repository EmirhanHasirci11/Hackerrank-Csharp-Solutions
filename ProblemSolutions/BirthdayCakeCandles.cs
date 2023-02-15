namespace BirthdayCakeCandles
{
    internal class BirthdayCakeCandles
    {
        static void Main(string[] args)
        {
            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = birthdayCakeCandles(candles);
            Console.WriteLine(result);
        }
        public static int birthdayCakeCandles(List<int> candles)
        {
            int count = 0;
            int control = 0;
            candles.OrderByDescending(x => x).ToList().ForEach(x =>
            {
                control = control == 0 ? x : control;
                count += control == x ? 1 : 0;                                
            });
            return count;
        }
    }
}