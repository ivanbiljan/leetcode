public class Solution {
    public bool IsIsomorphic(string s, string t) {
        var map = new Dictionary<char, char>();
        for (var i = 0; i < s.Length; ++i) {
            if (map.Any(kvp => kvp.Key == s[i] && kvp.Value != t[i] || kvp.Value == t[i] && kvp.Key != s[i])) {
                return false;
            }

            map[s[i]] = t[i];
        }

        return true;
    }
}