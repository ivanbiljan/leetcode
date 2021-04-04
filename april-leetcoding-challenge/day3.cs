public class Solution {
    public int LongestValidParentheses(string s) {
        if (string.IsNullOrWhiteSpace(s)) {
            return 0;
        }
        
        var max = 0;
        var stack = new Stack<int>();
        var start = -1;
        for (var i = 0; i < s.Length; ++i) {
            if (s[i] == '('){
                stack.Push(i);
            }
            else {
                if (stack.Count == 0) {
                    start = i;
                }
                else {
                    stack.Pop();
                    if (stack.Count == 0) {
                        max = Math.Max(max, i - start);
                    }
                    else {
                        max = Math.Max(max, i - stack.Peek());
                    }
                }
            }
        }
        
        return max;
    }
}