public class Solution {
    public bool CheckValidString(string s) {
        var asteriskStack = new Stack<int>();
        var stack = new Stack<int>();
        for (var i = 0; i < s.Length; ++i) {
            var c = s[i];
            if (c == '(') {
                stack.Push(i);
            } else if (c == '*') {
                asteriskStack.Push(i);
            } else {
                if (stack.Count>0){
                    stack.Pop();
                } else if (asteriskStack.Count>0){
                    asteriskStack.Pop();
                } else {
                    return false;
                }
            }
        }

        while (stack.Count > 0 && asteriskStack.Count > 0) {
            if (stack.Pop() > asteriskStack.Pop()) {
                return false;
            }
        }

        return stack.Count == 0;
    }
}