public class Solution {
    public int[][] FindFarmland(int[][] land) {
        var ans = new List<int[]>();
        for (var row = 0; row < land.Length; ++row) {
            for (var col = 0; col < land[0].Length; ++col) {
                if (land[row][col] == 0) {
                    continue;
                }

                var row2 = row;
                var col2 = col;

                while (row2 + 1 < land.Length && land[row2 + 1][col2] == 1) {
                    ++row2;
                }

                while (col2 + 1 < land[0].Length && land[row2][col2 + 1] == 1) {
                    ++col2;
                }

                for (var i = row; i <= row2; ++i) {
                    for (var j = col; j <= col2; ++j) {
                        land[i][j] = 0;
                    }
                }

                ans.Add(new int[] {row, col, row2, col2});
            }
        }

        return ans.ToArray();
    }
}