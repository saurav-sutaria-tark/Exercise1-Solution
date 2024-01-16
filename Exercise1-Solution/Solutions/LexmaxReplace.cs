
using System.Text;

namespace Exercise1_Solution.Solutions
{
    public class LexmaxReplace
    {
        public StringBuilder Get(String s, String t)
        {
            char[] ch = t.ToCharArray();
            Array.Sort(ch);
            StringBuilder ans = new StringBuilder(s);
            int i=0, j = ch.Length-1;
            while(i < s.Length && j >= 0)
            {
                if (ans[i] < ch[j])
                {
                    ans[i] = ch[j];
                    j--;
                }
                i++;
            }
            return ans; 
        }
    }
}
