using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution.Solutions
{
    public class DukeOnChessBoard
    {
        public string DukePath(int n, string initPosition)
        {
            string ans = "";
            Dictionary<int,char> col = new Dictionary<int,char>();
            for (int i = 0; i < n; i++) col[i] = (char)(i + 'a');
            Dictionary<int,int> row = new Dictionary<int,int>();
            for (int i = 0; i < n; i++) row[i] = n - i;
            bool[,] visited = new bool[n+1, n+1];
            int currRow = n - (int)(initPosition[1] - '0');
            int currCol = (int)(initPosition[0] - 'a');
            bool end = false;
            IsPathPossible(ref ans, row, col,currRow,currCol,ref visited,n,ref end);
            if(ans.Length > 40)  return $"{ans.Substring(1,20)}...{ans.Substring(ans.Length - 20,20)}";  
            return ans.Substring(1);
        }
        public void IsPathPossible(ref string ans,Dictionary<int,int> row, Dictionary<int,char> col,int currRow,int currCol,ref bool[,] visited,int n,ref bool end)
        {

            if (currRow >= n || currRow < 0 || currCol < 0 || currCol >= n || visited[currRow, currCol]) return;
  
            visited[currRow, currCol] = true;
            ans += $"-{col[currCol]}{row[currRow]}";
            //right
            if(!end) IsPathPossible(ref ans,row,col,currRow,currCol+1,ref visited,n, ref end);
            //top
            if (!end) IsPathPossible(ref ans,row,col,currRow-1,currCol,ref visited,n, ref end);
            //bottom
            if (!end) IsPathPossible(ref ans, row, col, currRow + 1, currCol, ref visited, n, ref end);
            //left
            if (!end) IsPathPossible(ref ans, row, col, currRow, currCol - 1, ref visited, n,ref end);

            end = true;
            return;
            
        }
    }
}
