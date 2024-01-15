using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution.Solutions
{
    internal class TurningLightOn
    {
        public int MinFlips(string[] board)
        {
            int ans = 0;
            //int row = board.Length -1, col = board[0].Length -1;
            StringBuilder[] currState = new StringBuilder[board.Length];
            for (int i = 0; i < board.Length; i++) currState[i] = new StringBuilder(board[i]);
            for (int row = board.Length - 1; row >= 0; row--)
            {
                for (int col = board[row].Length - 1; col >= 0; col--)
                {
                    if (currState[row][col] == '0')
                    {
                        ans++;
                        FlipBulbs(currState, row, col);
                    }
                }
            }
            return ans;
        }
        public void FlipBulbs(StringBuilder[] board, int row, int col)
        {
            for (int i = 0; i <= row; i++)
            {
                for (int j = 0; j <= col; j++) board[i][j] = (board[i][j] == '0') ? '1' : '0';
            }
            return;
        }
    }
}
