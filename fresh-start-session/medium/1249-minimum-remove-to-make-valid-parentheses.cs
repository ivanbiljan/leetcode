public class Solution {
    public string MinRemoveToMakeValid(string s) {
        var depth = 0;
        var charArray = s.ToCharArray();
        for (var i = 0; i < s.Length; ++i) {
            if (charArray[i] == '(') {
                ++depth;
            } else if (charArray[i] == ')') {
                if (depth == 0) {
                    charArray[i] = '-';
                } else {
                    --depth;
                }
            }
        }

        for (var i = charArray.Length - 1; i >= 0 && depth > 0; --i) {
            if (charArray[i] == '(') {
                charArray[i] = '-';
                --depth;
            }
        }

        return new string(charArray.Where(c => c != '-').ToArray());
    }
}