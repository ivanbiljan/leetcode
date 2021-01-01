public class Solution {
    public IList<string> FindWords(char[][] board, string[] words) {
        if (board.GetLength(0) == 0 || words.Length == 0) {
            return new List<string>();
        }
        
        var results = new List<string>();
        for (var i = 0; i < board.GetLength(0); ++i) {
            for (var j = 0; j < board[0].Length; ++j) {
                foreach (var word in words) {
                    Dfs(board, i, j, word, 0, results);
                }
            }
        }
        
        return results;
    }
    
    public void Dfs(char[][] board, int row, int col, string word, int charIndex, List<string> resultSet) {
        if (charIndex >= word.Length) {
            if (!resultSet.Contains(word))
                resultSet.Add(word);
            return;
        }
        
        if (row < 0 || row >= board.GetLength(0) || col < 0 || col >= board[0].Length) {
            return;
        }
        
        if (board[row][col] == '#') {
            return;
        }
        
        if (board[row][col] != word[charIndex]) {
            return;
        }
        
        var copy = board[row][col];
        board[row][col] = '#';
        Dfs(board, row + 1, col, word, charIndex + 1, resultSet);
        Dfs(board, row - 1, col, word, charIndex + 1, resultSet);
        Dfs(board, row, col - 1, word, charIndex + 1, resultSet);
        Dfs(board, row, col + 1, word, charIndex + 1, resultSet);
        board[row][col] = copy;
        ++charIndex;
    }
}