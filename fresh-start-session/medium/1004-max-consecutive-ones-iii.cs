public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int ans = 0, start = 0, end = 0, zeroCnt = 0;
        while (end < nums.Length) {
            if (nums[end] == 1 || ++zeroCnt <= k) {
                ++end;
                continue;
            }

            ans = Math.Max(ans, end - start);
            while (zeroCnt > k) {
                if (nums[start++] == 0) {
                    --zeroCnt;
                }
            }

            ++end;
        }

        return Math.Max(ans, end - start);
    }
}