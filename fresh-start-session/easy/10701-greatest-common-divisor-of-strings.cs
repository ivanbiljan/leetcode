public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        if (str1 + str2 != str2 + str1) {
            return "";
        }

        var gcd = Gcd(Math.Max(str1.Length, str2.Length), Math.Min(str1.Length, str2.Length));

        return str1[..gcd];
    }

    public int Gcd(int a, int b) {
        if (a % b == 0) {
            return b;
        }

        return Gcd(b, a % b);
    }
}