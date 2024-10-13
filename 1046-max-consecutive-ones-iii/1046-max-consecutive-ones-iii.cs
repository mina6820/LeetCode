public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int flipsNum = 0;
        int currentMax = 0;
        int maxFlips = 0;
        int left = 0;

        for (int i = 0; i < nums.Length; i++)
        {

            if (nums[i] == 1)
            {
                currentMax++;
            }
            else if (nums[i] == 0)
            {
                if (flipsNum < k)
                {
                    flipsNum++;
                    currentMax++;
                }
                else
                {

                    while (flipsNum >= k && left <= i)
                    {
                        if (nums[left] == 0)
                        {
                            flipsNum--; // Reduce flip count
                        }
                        currentMax--; // Shrink the window size
                        left++;
                    }

                    flipsNum++;
                    currentMax++;
                }
            }

            maxFlips = Math.Max(maxFlips, currentMax);
        }
        return maxFlips;
    }
}