using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution.Solutions
{
    public class MaximumBalances
    {
        public int Solve(String s)
        {   
            int openingParentheses = 0, closingParentheses = 0;
            foreach(char parantheses in s)
            {
                if(parantheses == '(') openingParentheses++;
                else closingParentheses++;
            }
            int minCount = int.Min(openingParentheses, closingParentheses);
            return (minCount*(1 + minCount)) / 2;
        }
    }
}
