public class Solution {
    public int[] TwoSum(int[] nums, int target) {
            // Key is the number, Vlaue is the index
            Dictionary<int , int> keyValuePairs = new Dictionary<int , int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if(keyValuePairs.ContainsKey(complement))
                {
                    return new int[] { keyValuePairs[complement], i };  
                    
                }
                else
                {
                    keyValuePairs[nums[i]] = i;        
                }
            }
            // if no solution return empty array
            return new int[0];
    }
}