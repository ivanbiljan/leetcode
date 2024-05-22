public class Solution {
    public IList<IList<string>> Partition(string s) {
        var ans = new List<IList<string>>();
        GetPalindromes(s, 0, new List<string>(), ans);
        return ans;
    }
    
    public void GetPalindromes(string s, int start, List<string> palindromes, List<IList<string>> result) {
        if (start >= s.Length) {
            result.Add(new List<string>(palindromes));
            return;
        }
        
        for (var i = start; i < s.Length; ++i) {
            if (IsPalindrome(s, start, i)) {
                var sub = s.Substring(start, i - start + 1);
                palindromes.Add(sub);
                GetPalindromes(s, i + 1, palindromes, result);
                palindromes.RemoveAt(palindromes.Count - 1);
            }
        }
    }
    
    private bool IsPalindrome(string s, int start, int end) {
        while (start < end) {
            if (s[start++] != s[end--]) {
                return false;
            }
        }
        
        return true;
    }
}