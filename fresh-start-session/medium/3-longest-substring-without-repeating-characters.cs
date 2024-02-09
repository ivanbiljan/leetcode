public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var seen = new HashSet<char>();
        
        var ans = 0;
        var start = 0;
        var end = 0;
        while (end < s.Length) {
            if (seen.Contains(s[end])) {
                ans = Math.Max(ans, end - start);
                while (seen.Contains(s[end])) {
                    seen.Remove(s[start++]);
                }
            }

            seen.Add(s[end]);
            ++end;
        }

        return Math.Max(ans, seen.Count);
    }
}