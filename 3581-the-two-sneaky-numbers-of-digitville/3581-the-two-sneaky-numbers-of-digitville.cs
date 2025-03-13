public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
                HashSet<int> seen = new HashSet<int>();
        List<int> result = new List<int>();

        foreach (int num in nums)
        {
            if (seen.Contains(num))
            {
                result.Add(num);
                if (result.Count == 2)
                    break;
            }
            else
            {
                seen.Add(num);
            }
        }

        return result.ToArray();
    }
}