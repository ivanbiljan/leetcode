public class Solution {
    public string RemoveDuplicates(string s, int k) {
        var stack = new Stack<KeyValuePair<char, int>>();
        
        var b = new StringBuilder();
        for (var i = 0; i < s.Length; ++i) {
            stack.Push(new KeyValuePair<char, int>(s[i], stack.Count > 0 && stack.Peek().Key == s[i] ? stack.Peek().Value + 1 : 1));
            b.Append(s[i]);
            if (stack.Peek().Value == k) {
                for (var j = 0; j < k; ++j) {
                    stack.Pop();
                    b.Remove(b.Length - 1, 1);
                }
            }
        }
        
        return b.ToString();
    }
}