public class Solution {
    public long MinimumSteps(string s) {
        
        int left = 0;
        long NumOfSteps = 0;

        for(int right = 0; right < s.Length; right++)
        {
            if(s[right] == '0')
            {
                NumOfSteps += right - left;
                left++;
            }
        }

        return NumOfSteps;

    }
}