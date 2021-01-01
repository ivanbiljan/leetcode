public class Solution {
    public bool Exist(char[][] board, string word) {
        for (var i = 0; i < board.GetLength(0); ++i) {
            for (var j = 0; j < board[0].Length; ++j) {
                if (Dfs(board, i, j, word, 0)) {
                    return true;
                }
            }
        }
        
        return false;
    }
    
    public bool Dfs(char[][] board, int row, int col, string word, int charIndex) {
        if (charIndex >= word.Length) {
            return true;
        }
        
        if (row < 0 || row >= board.GetLength(0) || col < 0 || col >= board[0].Length) {
            return false;
        }
        
        if (board[row][col] != word[charIndex]) {
            return false;
        }
        
        if (board[row][col] == '#') {
            return false;
        }
        
        var charCopy = board[row][col];
        board[row][col] = '#';
        var exists =  Dfs(board, row + 1, col, word, charIndex + 1) ||
                      Dfs(board, row - 1, col, word, charIndex + 1) ||
                      Dfs(board, row, col - 1, word, charIndex + 1) ||
                      Dfs(board, row, col + 1, word, charIndex + 1);
        if (!exists) {
            board[row][col] = charCopy;
        }
        
        return exists;
    }
}