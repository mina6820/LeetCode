public class Solution {
    public bool IncreasingTriplet(int[] nums) {

        // contiguous
        // if(nums.Length < 3) return false;
        // int loops = nums.Length % 2 == 0 ? nums.Length - 2 : nums.Length - 3; 

        // int first = 0;
        // int second = 1;
        // int third = 2;

        // for (int i = 0; i < loops; i++)
        // {
        //     if (nums[first] < nums[second] && nums[second] < nums[third])
        //     {
        //         return true;
        //     }
        //     first++; second++; third++;
        // }
        // return false;



        int smallest = nums.Max();
        int second_smallest = nums.Max();

        for(int i = 0; i < nums.Length; i++ )
        {
            if(nums[i] <= smallest)
                smallest = nums[i];
            else if(nums[i] <= second_smallest)
                second_smallest = nums[i];
            else
                return true;
        }

        return false;
    }
}