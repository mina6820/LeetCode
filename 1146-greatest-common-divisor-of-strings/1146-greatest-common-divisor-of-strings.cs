public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        // If concatenating str1 + str2 is the same as str2 + str1, then they share a common divisor
        if ((str1 + str2) != (str2 + str1))
            return "";

        // The GCD length will be the GCD of the lengths of str1 and str2
        int gcdLength = Gcd(str1.Length, str2.Length);

        // Return the substring of str1 from 0 to gcdLength
        return str1[..gcdLength];
    }

    private int Gcd(int a, int b) {
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

}