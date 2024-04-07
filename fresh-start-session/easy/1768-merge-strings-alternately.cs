public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var ans = new StringBuilder();

        var len = Math.Max(word1.Length, word2.Length);
        for (var i=0;i<len;++i) {
            if (i>=word1.Length) {
                ans.Append(word2[i]);
            } else if (i>=word2.Length) {
                ans.Append(word1[i]);
            } else {
                ans.Append($"{word1[i]}{word2[i]}");
            }
        }

        return ans.ToString();
    }
}