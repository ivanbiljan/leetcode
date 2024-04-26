public class Solution {
    public int MinFallingPathSum(int[][] grid) {
        var dp = new int[grid.Length, grid[0].Length];
        for (var row = 0; row < grid.Length; ++row) {
            for (var col = 0; col < grid[row].Length; ++col) {
                if (row == 0) {
                    dp[row, col] = grid[row][col];
                    continue;
                }

                var min = int.MaxValue;
                for (var col2 = 0; col2 < grid[row].Length; ++col2) {
                    if (col2 == col) {
                        continue;
                    }

                    min = Math.Min(min, dp[row - 1, col2] + grid[row][col]);
                }

                dp[row, col] = min;
            }
        }

        var ans = dp[grid.Length - 1, 0];
        for (var col = 1; col < grid[0].Length; ++col) {
            ans = Math.Min(ans, dp[grid.Length - 1, col]);
        }

        return ans;
    }
}