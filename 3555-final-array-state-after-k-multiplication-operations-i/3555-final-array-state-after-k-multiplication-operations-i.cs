public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier) {
        for(int i = 0; i < k; i++)
        {
            var minIndex = 0;
            for(int j =1; j < nums.Length; j++)
            {
                if(nums[minIndex] > nums[j]) minIndex = j;
            }

            nums[minIndex ] *= multiplier;
        }
        return nums;
    }
}