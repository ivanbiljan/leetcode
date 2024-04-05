public class Solution {
    public string MakeGood(string s) {
        const int diff = 'a' - 'A';

        var stack = new Stack<char>();
        foreach (var c in s) {
            if (stack.Count > 0 && (int)Math.Abs(stack.Peek() - c) is diff) {
                stack.Pop();
            } else {
                stack.Push(c);
            }
        }
        
        var ans = new char[stack.Count];
        while (stack.Count > 0) {
            ans[stack.Count - 1] = stack.Pop();
        }

        return new string(ans);
    }
}