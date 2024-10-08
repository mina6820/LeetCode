public class Solution
{
    public int MaxOperations(int[] nums, int k)
    {
        Array.Sort(nums);
        int answer = 0;
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int sum = nums[left] + nums[right];
            
            if (sum == k)
            {
                answer++;
                left++;
                right--;
            }
            else if (sum < k)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return answer;
    }
}