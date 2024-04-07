public class Solution {
    public string ReverseVowels(string s) {
        int start = 0, end = s.Length - 1;

        var arr = s.ToCharArray();
        while (start < end) {
            if (!IsVowel(s[start])) {
                ++start;
            } else if (!IsVowel(s[end])) {
                --end;
            } else {
                (arr[start], arr[end]) = (arr[end], arr[start]);
                ++start;
                --end;
            }
        }

        return new string(arr);
    }

    public bool IsVowel(char c) {
        return "aeiou".IndexOf(char.ToLower(c)) >= 0;
    }
}