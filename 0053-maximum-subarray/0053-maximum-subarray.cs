public class Solution {
    public int MaxSubArray(int[] nums) {

            // int maxSum = int.MinValue;
            // for (int i = 0; i < nums.Length; i++)
            // {
            //    int currenSum = 0;

            //    for (int j = i; j < nums.Length; j++) 
            //    {
            //        currenSum += nums[j];
            //        if (currenSum > maxSum)
            //        {
            //            maxSum = currenSum;
            //        }
            //    }
            // }

        // Better Solution 
        int maxSum = nums[0];
        int currentSum = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            currentSum = Math.Max(nums[i], currentSum + nums[i]);
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }
}