using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution.Solutions
{
    internal class PrintScheduler
    {
        public string GetOutput(string[] threads, string[] slices)
        {
            string ans = "";
            int[] lastLeft = new int[threads.Length];
            foreach (string s in slices)
            {
                string[] slice = s.Split(' ');
                int threadIdx = Int32.Parse(slice[0]);
                int threadTime = Int32.Parse(slice[1]);
                for (int i = 0; i < threadTime; i++)
                {
                    ans += threads[threadIdx][lastLeft[threadIdx]];
                    lastLeft[threadIdx] = (lastLeft[threadIdx] + 1) % (threads[threadIdx].Length);
                }

            }
            return ans.ToString();

        }
    }
}
