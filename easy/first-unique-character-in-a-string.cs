public class Solution {
    public int FirstUniqChar(string s) {
        // Bruteforce: O(n^2) time, O(1) space
        // Array: O(n) time, O(1) space
        var repeats = new int[26];
        for (var i = 0; i < s.Length; ++i) {
            ++repeats[s[i] - 'a'];
        }
        
        for (var i = 0; i < s.Length; ++i) {
            if (repeats[s[i] - 'a'] == 1) {
                return i;
            }
        }
        
        return -1;
    }
}