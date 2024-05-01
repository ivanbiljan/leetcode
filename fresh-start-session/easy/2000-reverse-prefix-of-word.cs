public class Solution {
    public string ReversePrefix(string word, char ch) {
        var ix = word.IndexOf(ch);
        var arr = word.ToCharArray();
        for (var i = 0; i < (ix + 1) / 2; ++i) {
            (arr[i], arr[ix - i]) = (arr[ix - i], arr[i]);
        }

        return new string(arr);
    }
}