public class Solution {
    public int MaxArea(int[] height) {
        var ans = 0;
        int start = 0, end = height.Length - 1;
        while (start < end) {
            ans = Math.Max(ans, (end - start) * Math.Min(height[start], height[end]));
            if (height[start] < height[end]) {
                ++start;
            } else {
                --end;
            }
        }

        return ans;
    }
}