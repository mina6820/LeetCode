public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] sArray = s.ToCharArray();
        Array.Sort(sArray);

        char[] tArray = t.ToCharArray();
        Array.Sort(tArray);

        string sortedS = new string(sArray);
        string sortedT = new string(tArray);

        return sortedS == sortedT;
    }
}