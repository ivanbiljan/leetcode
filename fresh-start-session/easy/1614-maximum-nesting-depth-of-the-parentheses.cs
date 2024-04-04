public class Solution {
    public int MaxDepth(string s) {
        var ans = 0;
        var depth = 0;
        foreach (var c in s) {
            if (c == '(') {
                ans = Math.Max(ans, ++depth);
            }

            if (c == ')') {
                --depth;
            }
        }

        return ans;
    }
}