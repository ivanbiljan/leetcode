public class Solution {
    public bool IsPalindrome(string s) {
        int start = 0, end = s.Length - 1;
        while (start < end) {
            if (!IsAllowed(s[start])) {
                ++start;
            } else if (!IsAllowed(s[end])) {
                --end;
            } else {
                if (char.ToLower(s[start++]) != char.ToLower(s[end--])) {
                    return false;
                }
            }
        }

        return true;
    }
    
    public bool IsAllowed(char c) {
        return char.ToLower(c) is (>= 'a' and <= 'z') or (>= '0' and <= '9');
    }
}