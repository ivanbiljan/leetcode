public class Solution {
    public string RemoveKdigits(string num, int k) {
        if (num.Length == k) {
            return "0";
        }

        var stack = new Stack<char>();
        foreach (var digit in num) {
            while (k > 0 && stack.Count > 0 && stack.Peek() > digit) {
                stack.Pop();
                --k;
            }

            stack.Push(digit);
        }

        while (k > 0) {
            stack.Pop();
            --k;
        }

        var ans = new char[stack.Count];
        while (stack.Count > 0) {
            ans[stack.Count - 1] = stack.Pop();
        }

        var offset = 0;
        while (offset < ans.Length - 1 && ans[offset] == '0') {
            ++offset;
        }

        return new string(ans[offset..]);
    }
}