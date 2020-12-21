public class Solution {
    public string RemoveDuplicates(string S) {
        var stack = new Stack<char>();
        var reversedStack = new Stack<char>();
        for (var i = 0; i < S.Length; ++i) {
            if (stack.Count > 0 && stack.Peek() == S[i]) {
                stack.Pop();
            } else {
                stack.Push(S[i]);
            }
        }
        
        var builder = new StringBuilder();
        while (stack.Count > 0) {
            reversedStack.Push(stack.Pop());
        }
        
        foreach (var element in reversedStack) {
            builder.Append(element);
        }
        
        return builder.ToString();
    }
}