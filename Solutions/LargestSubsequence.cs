using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution.Solutions
{
    internal class LargestSubsequence
    {
        public string GetLargest(string s)
        {
            StringBuilder prevMax = new StringBuilder(s[0] + "");
            for(int i = 1; i < s.Length; i++)
            {
                char currChar = s[i];
                bool placed = false;
                for(int j = 0; j < prevMax.Length; j++)
                {
                    if(currChar > prevMax[j])
                    {
                        prevMax[j] = currChar;
                        prevMax.Remove(j+1,prevMax.Length - j -1);
                        placed = true;
                        break;
                    }
                }
                if(!placed) prevMax.Append(currChar);
            }
            return prevMax.ToString();
            
        }
        //recusrive method : TLE on last case
        //public string FindLargestSequence(string temp,string s, int index)
        //{
        //    if(index >= s.Length)
        //    {
        //        int ans = String.Compare(temp, s);
        //        if (ans > 0) return temp;
        //        return s;
        //    }
        //    string taken = FindLargestSequence(temp + s[index], s, index+1);
        //    string notTaken = FindLargestSequence(temp,s, index+1);
        //    int compare = String.Compare(taken, notTaken);
        //    if(compare > 0) return taken;
        //    return notTaken;
        //}
    }
}
