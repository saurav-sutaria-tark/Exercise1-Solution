using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution.Solutions
{
    public class MysticAndCandiesEasy
    {
        public int MinBoxes(int C, int X, int[] high)
        {
            Array.Sort(high);
            int idx = 0;
            int candiesLeft = C;
            while (idx < high.Length)
            {
                candiesLeft -= high[idx];
                if (candiesLeft < X) break;
                idx++;
            }
            return high.Length - idx;
        }
    }
}
