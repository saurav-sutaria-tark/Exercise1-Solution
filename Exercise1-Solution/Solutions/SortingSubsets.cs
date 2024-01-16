

namespace Exercise1_Solution.Solutions
{
    public class SortingSubsets
    {
        public int GetMinimalSize(int[] a)
        {
            int ans = 0;
            int[] currArr = new int[a.Length];
            a.CopyTo(currArr, 0);
            Array.Sort(a);
           
            for(int i = 0; i < a.Length; i++)
            {
                if (currArr[i] != a[i]) ans++;
            }
            return ans;
        }
    }
}
