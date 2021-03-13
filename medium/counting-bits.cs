public class Solution {
    public int[] CountBits(int num) {
        // Straight-forward:
        /*var results = new int[num + 1];
        for (var i = 0; i <= num; ++i) {
            results[i] = GetBitCount(i);
        }
        
        int GetBitCount(int num) {
            var counter = 0;
            while (num > 0) {
                if ((num & 1) != 0) {
                    ++counter;
                }
                
                num >>= 1;
            }
            
            return counter;
        }
        
        return results;*/
        
        // DP:
        var dp = new int[num + 1];
        if (num == 0) {
            return dp;
        }
        
        dp[0] = 0;
        dp[1] = 1;
        for (var i = 2; i <= num; ++i) {
            if (i % 2 == 0) {
                dp[i] = dp[i / 2];
            } else {
                dp[i] = dp[(i - 1) / 2] + 1;
            }
        }
        
        return dp;
    }
}