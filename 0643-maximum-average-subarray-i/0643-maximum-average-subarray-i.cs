public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int sum = 0;
        double MaxAvg = Int32.MinValue;
        double Avg = 0;

        for(int i = 0; i < k; i++)
        {
            sum += nums[i];
        }

        MaxAvg = (double)sum / k;

        for(int j = k; j < nums.Length; j++)
        {
            sum += nums[j];
            sum -= nums[j - k];
            Avg = (double)sum / k;
            MaxAvg = Math.Max(Avg, MaxAvg);
        }


        return MaxAvg;
    }
}