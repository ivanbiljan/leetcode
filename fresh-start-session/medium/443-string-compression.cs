public class Solution {
    public int Compress(char[] chars) {
        var cnt = 1;
        var ix = 0;
        for (var i = 1; i < chars.Length; ++i) {
            if (chars[i] == chars[i - 1]) {
                ++cnt;
                continue;
            }

            chars[ix++] = chars[i - 1];
            if (cnt > 1) {
                foreach (var c in cnt.ToString()) {
                    chars[ix++] = c;
                }
            }

            cnt = 1;
        }

        chars[ix++] = chars[chars.Length - 1];
        if (cnt > 1) {
            foreach (var c in cnt.ToString()) {
                chars[ix++] = c;
            }
        }

        return ix;
    }
}