using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution.Solutions
{
    public class Islands
    {
        public int BeachLength(string[] kingdom)
        {
            int ans = 0;
            for(int row=0;row<kingdom.Length;row++)
            {
                for(int col = 0; col < kingdom[row].Length; col++)
                {
                    char currCell = kingdom[row][col];
                    if(currCell == '#')
                    {
                        //left side
                        if (IsValidCell(row, col - 1, kingdom) && kingdom[row][col - 1] == '.') ans++;
                        //rightSide
                        if (IsValidCell(row, col + 1, kingdom) && kingdom[row][col + 1] == '.') ans++;
                        //even row
                        if (row % 2 == 0)
                        {
                            //top row
                            if (IsValidCell(row - 1, col - 1, kingdom) && kingdom[row - 1][col - 1] == '.') ans++;
                            if (IsValidCell(row - 1, col, kingdom) && kingdom[row - 1][col] == '.') ans++; 
                            
                            //bottom row
                            if (IsValidCell(row + 1, col - 1, kingdom) && kingdom[row + 1][col - 1] == '.') ans++;
                            if (IsValidCell(row + 1, col, kingdom) && kingdom[row + 1][col] == '.') ans++;
                        }
                        //odd row
                        else
                        {
                            //top row
                            if (IsValidCell(row - 1, col, kingdom) && kingdom[row - 1][col] == '.') ans++;
                            if (IsValidCell(row - 1, col+1, kingdom) && kingdom[row - 1][col+1] == '.') ans++;

                            //bottom row
                            if (IsValidCell(row + 1, col, kingdom) && kingdom[row + 1][col] == '.') ans++;
                            if (IsValidCell(row + 1, col+1, kingdom) && kingdom[row + 1][col + 1] == '.') ans++;
                        }       
                    }
                }
            }
            return ans;
        }
        public bool IsValidCell(int row, int col,string[] kingdom)
        {
            if (row < 0 || col < 0 || row >= kingdom.Length || col >= kingdom[0].Length) return false;
            return true;
        }
    }
}
