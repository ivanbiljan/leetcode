public class Solution {
    public bool HalvesAreAlike(string s) {
        var vowels = new List<char> {'a', 'e', 'i', 'o', 'u'};
        
        var firstHalf = 0;
        var secondHalf = 0;
        
        for (int i = 0, j = s.Length - 1; i < j; ++i, --j) {
            if (vowels.Contains(char.ToLower(s[i]))) {
                ++firstHalf;
            }
            
            if (vowels.Contains(char.ToLower(s[j]))) {
                ++secondHalf;
            }
        }
        
        return firstHalf == secondHalf;
    }
}