using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution.Solutions
{
    public class Mailbox
    {
        public int Impossible(string collection, string[] address)
        {
            int ans = 0;
            Dictionary<char,int> collectionCount = new Dictionary<char,int>();
            foreach(char  c in collection)
            {
                if (collectionCount.ContainsKey(c)) collectionCount[c]++;
                else collectionCount[c] = 1;
            }
            for(int i = 0; i < address.Length; i++)
            {
                Dictionary<char,int> currCount = new Dictionary<char,int>();
                foreach(char c in address[i])
                {
                    if (c == ' ') continue;
                    if (currCount.ContainsKey(c)) currCount[c]++;
                    else currCount[c] = 1;
                }
                foreach(char key in currCount.Keys)
                {
                    
                    if (!collectionCount.ContainsKey(key))
                    {
                        ans++;
                        break;
                    }
                    if (collectionCount[key] < currCount[key])
                    {
                        ans++;
                        break;
                    }
                }
            }
            return ans;
        }
    }
}
