public class Solution {
    public bool IsSubsequence(string s, string t) {
        int sptr = 0, tptr = 0;
        while (sptr < s.Length && tptr < t.Length) {
            if (s[sptr] == t[tptr]) {
                sptr++;
            }

            tptr++;
        }

        return sptr == s.Length;
    }
}