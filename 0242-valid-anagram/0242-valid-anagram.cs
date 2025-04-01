public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> sDictionary = new Dictionary<char, int>();
        Dictionary<char, int> tDictionary = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (sDictionary.ContainsKey(s[i])) sDictionary[s[i]]++;
            else sDictionary.Add(s[i], 1);

            if (tDictionary.ContainsKey(t[i])) tDictionary[t[i]]++;
            else tDictionary.Add(t[i], 1);
        }


        foreach (var c in sDictionary)
        {
            tDictionary.TryGetValue(c.Key, out int tCount);
            if (c.Value != tCount)
            {
               return false;
            }
        }

        return true;
    }
}