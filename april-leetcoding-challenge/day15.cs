public class Solution {
    public int Fib(int n) {
        // Approach #1:
        /*if (n == 0 || n == 1) {
            return n;
        }
        
        return Fib(n - 1) + Fib(n - 2);*/
        
        // Approach #2:
        if (n < 2) {
            return n;
        }
        
        var memo = new int[n + 1];
        memo[0] = 0;
        memo[1] = 1;
        
        for (var i = 2; i <= n; ++i) {
            memo[i] = memo[i -1] + memo[i - 2];
        }
        
        return memo[n];
        
        // Approach #3: TODO
    }
}