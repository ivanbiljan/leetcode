public class Solution {
    public int MinRectanglesToCoverPoints(int[][] points, int w) {
        Array.Sort(points, (a, b) => { return a[0] - b[0]; });

        var ans = 0;
        var remaining = w;
        for (var i = 1; i < points.Length; ++i) {
            var diff = points[i][0] - points[i - 1][0];
            if (diff > remaining) {
                ++ans;
                remaining = w;
            } else {
                remaining -= diff;
            }
        }

        return ans + 1;
    }
}