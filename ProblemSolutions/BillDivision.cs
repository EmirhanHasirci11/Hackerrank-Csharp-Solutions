
namespace BillDivision
{
    internal class BillDivision
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            bonAppetit(bill, k, b);
        }
        public static void bonAppetit(List<int> bill, int k, int b)
        {
            int debt= ((bill.Sum() - bill[k]) / 2) -b;
            Console.WriteLine(debt==0?"Bon Appetit":Math.Abs(debt));
            
        }
    }
}