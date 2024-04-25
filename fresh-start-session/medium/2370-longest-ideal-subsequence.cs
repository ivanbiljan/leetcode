public class Solution {
    public int LongestIdealString(string s, int k) {
        var dp = new int['z' - 'a' + 1];
        foreach (var c in s) {
            var charIndex = c - 'a';
            var lowerBound = Math.Max(charIndex - k, 0);
            var upperBound = Math.Min(charIndex + k, dp.Length - 1);
            var longestSubsequence = 0;
            for (var i = lowerBound; i <= upperBound; ++i) {
                longestSubsequence = Math.Max(longestSubsequence, dp[i]);
            }

            dp[charIndex] = longestSubsequence + 1;
        }

        return dp.Max();
    }
}