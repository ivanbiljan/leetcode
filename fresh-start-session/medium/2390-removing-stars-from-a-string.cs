public class Solution {
    public string RemoveStars(string s) {
        var stack = new Stack<char>();
        foreach (var c in s) {
            if (c == '*') {
                stack.Pop();
            } else {
                stack.Push(c);
            }
        }

        var arr = new char[stack.Count];
        for (var i = stack.Count - 1; i >= 0; --i) {
            arr[i] = stack.Pop();
        }

        return new string(arr);
    }
}