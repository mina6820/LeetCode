public class Solution {
    public int LargestAltitude(int[] gain) {
        int[] altitutes = new int[gain.Length + 1];
        altitutes[0] = 0;

        for (int i = 1; i <= gain.Length; i++)
        {
            altitutes [i] = gain [i - 1] + altitutes[i - 1];
        }

        return altitutes.Max();

    }
}