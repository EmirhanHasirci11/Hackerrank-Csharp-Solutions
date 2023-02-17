namespace DesignerPDFViewer
{
    internal class DesignerPDFViewer
    {
        static void Main(string[] args)
        {
            List<int> h = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(hTemp => Convert.ToInt32(hTemp)).ToList();

            string word = Console.ReadLine();

            int result = designerPdfViewer(h, word);
            Console.WriteLine(result);
        }
        public static int designerPdfViewer(List<int> h, string word)
        {
            int maxHeight = 0;
            foreach(char c in word)
            {
                maxHeight = h[c-'a'] > maxHeight ? h[c - 'a'] : maxHeight;
            }
            return maxHeight*word.Length;
        }
    }
}