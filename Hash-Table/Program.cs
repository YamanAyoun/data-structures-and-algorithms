using System.Collections.Generic;

namespace Hash_Table
{
    internal class Program
    {
        public static string MostCommonWord(string book)
        {
            string[] words = book.ToLower().Split();


            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            string mostCommon = "";
            int maxCount = 0;

            foreach (string word in words)
            {

                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {

                    wordCount[word] = 1;
                }

                if (wordCount[word] > maxCount)
                {
                    mostCommon = word;
                    maxCount = wordCount[word];
                }
            }
            return mostCommon;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MostCommonWord("In a galaxy far far away"));  // Output: "far"
            Console.WriteLine(MostCommonWord("Taco cat ate a taco"));       // Output: "taco"
            Console.WriteLine(MostCommonWord("No no . Try not. Do or do not. There is no try."));  // Output: "no"

        }
    }
}