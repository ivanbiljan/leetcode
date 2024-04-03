public class Solution {
    public bool Exist(char[][] board, string word) {
        for (var i = 0; i < board.Length; ++i) {
            for (var j = 0; j < board[0].Length; ++j) {
                if (board[i][j] == word[0] && Dfs(board, i, j, word, 0)) {
                    return true;
                }
            }
        }

        return false;
    }

    public bool Dfs(char[][] board, int row, int col, string word, int charIndex) {
        if (row < 0 || row >= board.Length || col < 0 || col >= board[0].Length) {
            return false;
        }

        if (board[row][col] != word[charIndex]) {
            return false;
        }

        if (charIndex == word.Length - 1) {
            return true;
        }

        var temp = board[row][col];
        board[row][col] = '0';
        var ans = Dfs(board, row - 1, col, word, charIndex + 1) ||
                  Dfs(board, row + 1, col, word, charIndex + 1) ||
                  Dfs(board, row, col - 1, word, charIndex + 1) ||
                  Dfs(board, row, col + 1, word, charIndex + 1);

        board[row][col] = temp;
        
        return ans;
    }
}