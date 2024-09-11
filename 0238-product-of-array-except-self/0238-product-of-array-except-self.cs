public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        int[] result = new int[nums.Length];

        int previous = 1;
        int next = 1;

        for (int i = 0; i < nums.Length; i++) 
        {
            result[i] = previous;
            previous *= nums[i];
        }

        for(int i = nums.Length - 1; i >= 0; i--) 
        {
            result[i] *= next;
            next *= nums[i];
        }
        return result;
    }
}