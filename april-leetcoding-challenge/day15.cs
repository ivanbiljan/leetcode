public class Solution {
    public int Fib(int n) {
        if (n < 2) {
            return n;
        }
        
        // Approach #1:
        //return Fib(n - 1) + Fib(n - 2);*/
        
        // Approach #2:
        /*var memo = new int[n + 1];
        memo[0] = 0;
        memo[1] = 1;
        
        for (var i = 2; i <= n; ++i) {
            memo[i] = memo[i -1] + memo[i - 2];
        }
        
        return memo[n];*/
        
        // Approach #3:
        var x = 0;
        var y = 1;
        for (var i = 2; i <= n; ++i) {
            var z = x + y;
            x = y;
            y = z;
        }
        
        return y;
    }
}