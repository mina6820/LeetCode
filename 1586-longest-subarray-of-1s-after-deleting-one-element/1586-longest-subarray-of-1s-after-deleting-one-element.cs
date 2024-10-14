public class Solution {
    public int LongestSubarray(int[] nums) {
        
        int currentMax = 0;
        int Max = 0;
        int deleteNum = 0;
        int left = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 1)
            {
                currentMax++;
            }
            if(nums[i] == 0)
            {
                if(deleteNum == 0)
                {
                    deleteNum++;
                    currentMax++;
                }
                else
                {
                    while (deleteNum > 0 && left <= i)
                    {
                        if (nums[left] == 0)
                        {
                            deleteNum--; 
                        }
                        currentMax--;
                        left++;
                    }

                    deleteNum++;
                    currentMax++;
                }
                
            }

            Max = Math.Max(currentMax,Max);
        }

        return Max - 1;
    }
}