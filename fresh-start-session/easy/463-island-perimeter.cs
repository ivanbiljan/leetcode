public class Solution {
    public int IslandPerimeter(int[][] grid) {
        for (var row = 0; row < grid.Length; ++row) {
            for (var col = 0; col < grid[0].Length; ++col) {
                if (grid[row][col] != 1) {
                    continue;
                }

                return Dfs(grid, row, col);
            }
        }

        return 0;
    }

    private int Dfs(int[][] grid, int row, int col) {
        if (row < 0 || row >= grid.Length || col < 0 || col >= grid[0].Length) {
            return 1;
        }

        if (grid[row][col] == 0) {
            return 1;
        }

        if (grid[row][col] == -1) {
            return 0;
        }

        grid[row][col] = -1;
        
        return Dfs(grid, row - 1, col) +
               Dfs(grid, row + 1, col) +
               Dfs(grid, row, col - 1) +
               Dfs(grid, row, col + 1);
    }
}