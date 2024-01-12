
namespace Exercise1_Solution.Solutions
{
    internal class MovingAvg
    {
        public double Difference(int k,double[] data)
        {

            int startIdx = 0;
            
            double runningSum = 0;
            for(int i = 0; i < k; i++)
            {
                runningSum += data[i];
            }
            double minAvg = runningSum/k, maxAvg = runningSum/k;
            for(int i = k; i < data.Length; i++)
            {
                runningSum -= data[startIdx++];
                runningSum += data[i];
                double currAvg = runningSum/k;
                if(currAvg < minAvg) minAvg = currAvg;
                if(currAvg > maxAvg) maxAvg = currAvg;
            }
            return maxAvg - minAvg;
        }
    }
}
