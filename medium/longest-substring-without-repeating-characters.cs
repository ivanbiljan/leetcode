public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length <= 1) {
            return s.Length;
        }
        
        var first = 0;
        var second = 1;
        var set = new HashSet<char> {s[first]};
        
        var maxLength = 0;
        while (first < s.Length && second < s.Length) {
            if (set.Contains(s[second])) {
                set.Remove(s[first++]);
            } else {
                set.Add(s[second++]);
                maxLength = Math.Max(maxLength, second - first);
            }
        }
        
        return maxLength;
    }
}