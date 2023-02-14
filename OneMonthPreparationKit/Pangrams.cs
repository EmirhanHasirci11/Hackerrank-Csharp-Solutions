namespace Pangrams
{
    internal class Pangrams
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string result = Pangrams.pangrams(s.Replace(" ","").ToLower());
            Console.WriteLine(result);
        }
        public static string pangrams(string s)
        {
            List<char> current = new List<char>();
            char[] alphabet = "a b c d e f g h i j k l m n o p q r s t u v w x y z".Replace(" ", "").ToCharArray();       
            s.ToCharArray().ToList().ForEach(x =>
            {
                if (!current.Contains(x))
                {
                    current.Add(x);                   
                }
            });                        
            return alphabet.Except(current.ToArray()).Count() != 0  ?  "not pangram":"pangram"; 
        }

    }
}