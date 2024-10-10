public class Solution {
    public int MaxVowels(string s, int k) {
        int MaxVowel = 0;
        int currentVowels = 0;

        // Count vowels in the first 'k' characters
        for(int i = 0; i < k; i++) {
            if(IsVowel(s[i])) {
                currentVowels++;
            }
        }
        MaxVowel = currentVowels;

        // Sliding window: check the next character and remove the first character of the previous window
        for(int j = k; j < s.Length; j++) {
            if(IsVowel(s[j])) {
                currentVowels++; // add the new vowel
            }
            if(IsVowel(s[j - k])) {
                currentVowels--; // remove the old vowel
            }
            MaxVowel = Math.Max(MaxVowel, currentVowels); // update the maximum number of vowels
        }

        return MaxVowel;
    }

    // Helper function to check if a character is a vowel
    private bool IsVowel(char c) {
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}
