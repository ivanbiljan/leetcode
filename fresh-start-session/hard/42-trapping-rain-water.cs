public class Solution {
    public int Trap(int[] height) {
        int ans = 0, start = 0, end = height.Length - 1, leftHighest = height[0], rightHighest = height[height.Length - 1];
        while (start < end) {
            if (leftHighest < rightHighest) {
                ans += leftHighest - height[start];
                leftHighest = Math.Max(leftHighest, height[++start]);
            } else {
                ans += rightHighest - height[end];
                rightHighest = Math.Max(rightHighest, height[--end]);
            }
        }

        return ans;
    }
}