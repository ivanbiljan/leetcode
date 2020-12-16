public class Solution {
    public int MinSteps(string s, string t) {
        var sCharFrequencies = new int[26];
        var tCharFrequencies = new int[26];
        for (var i = 0; i < s.Length; ++i) {
            ++sCharFrequencies[s[i] - 'a'];
            ++tCharFrequencies[t[i]-  'a'];
        }
        
        int steps = 0;
        for (var i = 0; i < t.Length; ++i) {
            if (tCharFrequencies[t[i] - 'a'] - sCharFrequencies[t[i] - 'a'] <= 0) {
                continue;
            }
            
            ++steps;
            --tCharFrequencies[t[i] - 'a'];
        }
        
        return steps;
    }
}