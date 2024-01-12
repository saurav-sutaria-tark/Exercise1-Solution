
using static System.Formats.Asn1.AsnWriter;

namespace Exercise1_Solution.Solutions
{
    internal class WordCompositionGame
    {
        public string Score(string[] listA, string[] listB, string[] listC)
        {
            Dictionary<string,int> count = new Dictionary<string,int>();
            foreach (string word in listA) {
                if (count.ContainsKey(word)) count[word]++;
                else count[word] = 1;
            }foreach (string word in listB) {
                if (count.ContainsKey(word)) count[word]++;
                else count[word] = 1;
            }foreach (string word in listC) {
                if (count.ContainsKey(word)) count[word]++;
                else count[word] = 1;
            }
          
            int scoreA = 0, scoreB = 0, scoreC = 0;
            foreach (string word in listA) scoreA += getScore(count[word]);
            foreach (string word in listB) scoreB += getScore(count[word]);
            foreach (string word in listC) scoreC += getScore(count[word]);

            return $"{scoreA}/{scoreB}/{scoreC}";
           
        }
        public int getScore(int count)
        {
            if (count == 1) return 3;
            else if (count == 2) return 2;
            return 1;
        }
    }
}
