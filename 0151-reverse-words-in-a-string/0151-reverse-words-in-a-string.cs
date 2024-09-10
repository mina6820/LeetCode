public class Solution {
    public string ReverseWords(string s) {
        string output = "";
        string[] strings = s.Split(" ");

        for (int i = strings.Length-1 ; i >= 0; i--)
        {
            if (!string.IsNullOrEmpty(strings[i]))
            {
                output += strings[i] + " ";
            }
        }
        output = output.Trim();
        return output;
    }
}