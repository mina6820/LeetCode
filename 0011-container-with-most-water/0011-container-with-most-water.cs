public class Solution {
    public int MaxArea(int[] height) {
        if (height.Length == 0)
            return 0;

        int start = 0;
        int end = height.Length-1;
        int area = 0;

        while(start < end)
        {
            area = Math.Max(area, Math.Min(height[start], height[end]) * (end - start));
            if(height[start] < height[end])
            {
                start++;
            }
            else
            {
                end--;
            } 
        }
        return area;
    }
}