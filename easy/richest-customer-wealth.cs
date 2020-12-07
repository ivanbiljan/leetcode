public class Solution {
    public int MaximumWealth(int[][] accounts) {
        var max = 0;
        for (var i = 0; i < accounts.GetLength(0); ++i) {
            var wealth = 0;
            for (var j = 0; j < accounts[i].Length; ++j) {
                wealth += accounts[i][j];
            }
            
            if (wealth > max) {
                max = wealth;
            }
        }
        
        return max;
    }
}