public class Solution {
    public int MinOperations(int[] nums, int k) {
        var xor = k;
        foreach (var num in nums) {
            xor ^= num;
        }

        var ans = 0;
        while (xor > 0) {
            if ((xor & 1) == 1) {
                ++ans;
            }

            xor >>= 1;
        }

        return ans;
    }
}