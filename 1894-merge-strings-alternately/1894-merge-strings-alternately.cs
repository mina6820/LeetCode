public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder word3 = new StringBuilder();
        int minLength = Math.Min(word1.Length, word2.Length);
        
        for (int i = 0; i < minLength; i++) {
            word3.Append(word1[i]);
            word3.Append(word2[i]);
        }
        
        if (word1.Length > minLength) {
            word3.Append(word1[minLength..]);
        }
        
        if (word2.Length > minLength) {
            word3.Append(word2[minLength..]);
        }
        
        return word3.ToString(); 
        // StringBuilder word3 = new StringBuilder();
        // int i = 0, j = 0;

        // while (i < word1.Length || j < word2.Length)
        // {
        //     if (i < word1.Length)
        //     {
        //         word3.Append(word1[i]);
        //         i++;
        //     }
        //     if (j < word2.Length)
        //     {
        //         word3.Append(word2[j]);
        //         j++;
        //     }
        // }
        
        // return word3.ToString();
    }
}