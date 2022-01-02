public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        var ans = 0;
        for (var i = 0; i < grid.Length; ++i) {
            for (var j = 0; j < grid[0].Length; ++j) {
                if (grid[i][j] == 1) {
                    ans = Math.Max(ans, Dfs(grid, i, j));
                }
            }
        }
        
        return ans;
    }
    
    private int Dfs(int[][] grid, int i, int j) {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length) {
            return 0;
        }
        
        if (grid[i][j] <= 0) {
            return 0;
        }
        
        grid[i][j] = -1;
        return Dfs(grid, i + 1, j) + Dfs(grid, i - 1, j) + Dfs(grid, i, j + 1) + Dfs(grid, i, j - 1) + 1;
    }
}