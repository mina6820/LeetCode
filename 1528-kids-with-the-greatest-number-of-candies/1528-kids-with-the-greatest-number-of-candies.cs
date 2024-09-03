public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int KidMaxCandies = candies.Max();
        bool[] output = new bool[candies.Length];

        for(int i =0; i < candies.Length; i++)
        {
            if(candies[i] + extraCandies >= KidMaxCandies)
                output[i] = true;
            else
                output[i] = false;    
        }
        return output;
    }
}