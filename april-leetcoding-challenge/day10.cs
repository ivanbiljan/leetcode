public class Solution {
    public int LongestIncreasingPath(int[][] matrix) {
        var max = 0;
        var memo = new int[matrix.Length][];
        for (var i = 0; i < memo.Length; ++i) {
            memo[i] = new int[matrix[0].Length];
        }
        
        for (var i = 0; i < matrix.Length; ++i) {
            for (var j = 0; j < matrix[0].Length; ++j) {
                max = Math.Max(max, Bfs(matrix, i, j, memo));
            }
        }
        
        return max;
    }
    
    private bool IsValid(int[][] matrix, int i, int j) {
        return i >= 0 && i < matrix.Length && j >= 0 && j < matrix[0].Length && matrix[i][j] >= 0;
    }
    
    private int Bfs(int[][] matrix, int i, int j, int[][] memo) {
        var pathLength = 1;
        if (memo[i][j] > 0) {
            return memo[i][j];
        }
        
        if (IsValid(matrix, i, j + 1) && matrix[i][j + 1] < matrix[i][j]) {
            pathLength = Math.Max(pathLength, Bfs(matrix, i, j + 1, memo) + 1);
        }
        
        if (IsValid(matrix, i, j - 1) && matrix[i][j - 1] < matrix[i][j]) {
            pathLength = Math.Max(pathLength, Bfs(matrix, i, j - 1, memo) + 1);
        }
        
        if (IsValid(matrix, i + 1, j) && matrix[i + 1][j] < matrix[i][j]) {
            pathLength = Math.Max(pathLength, Bfs(matrix, i + 1, j, memo) + 1);
        }
        
        if (IsValid(matrix, i - 1, j) && matrix[i - 1][j] < matrix[i][j]) {
            pathLength = Math.Max(pathLength, Bfs(matrix, i - 1, j, memo) + 1);
        }
        
        memo[i][j] = pathLength;
        return pathLength;
    }
}