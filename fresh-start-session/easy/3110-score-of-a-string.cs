public class Solution {
    public int ScoreOfString(string s) {
        var ans = 0;
        for (var i = 1; i < s.Length; ++i) {
            ans += Math.Abs(s[i - 1] - s[i]);
        }   

        return ans;
    }
}