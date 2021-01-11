public class Solution {
    public bool IsPalindrome(string s) {
        if (s.Length <= 1) {
            return true;
        }
        
        var start = 0;
        var end = s.Length - 1;
        while (end > start) {
            if (!char.IsLetter(s[start]) && !char.IsDigit(s[start])) {
                ++start;
                continue;
            }
            
            if (!char.IsLetter(s[end]) && !char.IsDigit(s[end])) {
                --end;
                continue;
            }
            
            if (char.ToLower(s[start++]) != char.ToLower(s[end--])) {
                return false;
            }
        }
        
        return true;
    }
}