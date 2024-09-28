public class Solution {
    public int Compress(char[] chars) {
        int index = 0; // This will track the position in the compressed array
        int i = 0; // This will iterate through the array

        while (i < chars.Length)
        {
            char currentChar = chars[i]; 
            int count = 0;

            while (i < chars.Length && chars[i] == currentChar)
            {
                i++;
                count++;
            }

            chars[index++] = currentChar;

            if (count > 1)
            {
                foreach (char c in count.ToString())
                {
                    chars[index++] = c; 
                }
            }
        }

        return index;
        }
}