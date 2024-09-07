public class Solution {
    public string ReverseVowels(string s) {
    char[] chars = s.ToCharArray();  // Convert string to char array

    int start = 0;
    int end = s.Length - 1;

    while (start < end)
    {
        if (check(chars[start]) && check(chars[end]))
        {
            // Swap characters
            char temp = chars[start];
            chars[start] = chars[end];
            chars[end] = temp;

            start++;
            end--;
        }
        else
        {
            if (!check(chars[start])) start++;
            if (!check(chars[end])) end--;
        }
    }

    string result = new string(chars);
    return result;

    }

    public bool check(char c)
    {
        return "aeiouAEIOU".IndexOf(c) >= 0;
    }
}