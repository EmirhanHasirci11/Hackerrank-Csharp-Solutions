namespace CatsAndAMouse
{
    internal class CatsAndAMouse
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                string result = catAndMouse(x, y, z);

                Console.WriteLine(result);
            }
            static string catAndMouse(int x, int y, int z)
            {

                return Math.Abs(z - x) == Math.Abs(z - y) ? "Mouse C" : Math.Abs(z - x) < Math.Abs(y - z) ? "Cat A" : "Cat B";
            }
        }
    }
}