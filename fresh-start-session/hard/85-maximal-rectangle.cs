public class Solution {
    public int MaximalRectangle(char[][] matrix) {
        var ans = 0;

        for (var start = 0; start < matrix.Length; ++start) {
            for (var end = 0; end < matrix.Length; ++end) {
                var width = 0;
                for (var col = 0; col < matrix[0].Length; ++col) {
                    if (!IsValid(start, end, col)) {
                        width = 0;
                        continue;
                    }

                    ans = Math.Max(ans, ++width * (end - start + 1));
                }
            }
        }

        return ans;

        bool IsValid(int start, int end, int col) {
            for (var i = start; i <= end; ++i) {
                if (matrix[i][col] != '1') {
                    return false;
                }
            }

            return true;
        }
    }
}