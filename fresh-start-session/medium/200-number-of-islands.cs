public class Solution {
    public int NumIslands(char[][] grid) {
        var ans = 0;
        for (var row = 0; row < grid.Length; ++row) {
            for (var col = 0; col < grid[0].Length; ++col) {
                if (grid[row][col] != '1') {
                    continue;
                }

                ++ans;
                Dfs(grid, row, col);
            }
        }

        return ans;
    }

    public void Dfs(char[][] grid, int row, int col) {
        if (row < 0 || row >= grid.Length || col < 0 || col >= grid[0].Length) {
            return;
        }

        if (grid[row][col] != '1') {
            return;
        }

        grid[row][col] = '#';
        Dfs(grid, row - 1, col);
        Dfs(grid, row + 1, col);
        Dfs(grid, row, col - 1);
        Dfs(grid, row, col + 1);
    }
}