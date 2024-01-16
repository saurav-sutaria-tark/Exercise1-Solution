

using System.Text;

namespace Exercise1_Solution.Solutions
{
    public class PalindromeDecoding
    {
        public string Decode(String code, int[] position, int[] length)
        {
            StringBuilder ans = new StringBuilder(code);
            for(int i = 0; i < position.Length; i++)
            {
                StringBuilder subStr = new StringBuilder(ans.ToString().Substring(position[i], length[i]));
                //string revString = new string(subStr.ToString().Reverse().ToArray());
                int k=0,j=subStr.Length-1;
                while(k < j)
                {
                    char temp = (char)subStr[k];
                    subStr[k] = subStr[j];
                    subStr[j] = temp;
                    k++;j--;
                }
                ans.Insert(position[i] + length[i],subStr.ToString());
            }
            return ans.ToString();
        }
    }
}
