public class Solution {
    public int NumIslands(char[][] grid) {
        var islands = 0;
        for (var i = 0; i < grid.GetLength(0); ++i) {
            for (var j = 0; j < grid[0].Length; ++j) {
                if (grid[i][j] == '0') {
                    continue;
                }
                
                Dfs(grid, i, j);
                ++islands;
            }
        }
        
        return islands;
    }
    
    public void Dfs(char[][] grid, int row, int col) {
        if (row < 0 || row >= grid.GetLength(0) || col < 0 || col >= grid[0].Length) {
            return;
        }
        
        if (grid[row][col] == '0') {
            return;
        }
        
        grid[row][col] = '0';
        Dfs(grid, row - 1, col);
        Dfs(grid, row + 1, col);
        Dfs(grid, row, col - 1);
        Dfs(grid, row, col + 1);
    }
}