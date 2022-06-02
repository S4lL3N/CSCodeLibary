using System.Text;


namespace CodingExam
{
    public class WordCount
    {
        public static void WordOccurrence(string inputFile, int lines)
        {
            List<string> words = GetWordList(inputFile, lines);
            CountOccurrences(words);
            
        }

        private static List<string> GetWordList(string inputFile, int lines)
        {
            //read the first n lines
            var text = File.ReadLines(inputFile).Take(lines).ToArray();
            /*
            //For testing, output section of text parsed
            foreach (var x in text)
            {
                Console.WriteLine(x);
            }
            */

            List<string> wordList = new List<string>();
            foreach (var line in text)
            {
                //separate by whitespace 
                string[] temp = line.Split(" ");
                foreach (var word in temp)
                {
                    //ignore punctuation
                    StringBuilder sb = new StringBuilder();
                    foreach (char c in word)
                    {
                        if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                        {
                            sb.Append(c);
                        }
                    }
                    //normalize words to lowercase
                    if (sb.ToString().Length > 0) { wordList.Add(sb.ToString().ToLower()); }

                }

            }
            return wordList;
        }

        private static void CountOccurrences(List<string> words)
        {
            //count unique words 
            Dictionary<string, int> wordsAndOccurrence = new Dictionary<string, int>();
            for (int i = 0; i < words.Count; i++)
            {

                try
                {
                    wordsAndOccurrence.Add(words[i], 1);
                }
                catch
                {
                    wordsAndOccurrence[words[i]] = (int)wordsAndOccurrence[words[i]] + 1;
                }

            }

            //sort the dictionary by occurance descending
            var ordered = wordsAndOccurrence.OrderByDescending(p => p.Value);
            Console.WriteLine("Word Count:\nResults: ");
            foreach (var p in ordered)
            {
                Console.WriteLine(p.Key + " " + p.Value);
            }
        }
    }
}
