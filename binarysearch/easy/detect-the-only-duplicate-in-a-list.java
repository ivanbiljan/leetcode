import java.util.*;

class Solution {
    public int solve(int[] nums) {
        int expected = 0;
        for (int i = 1; i < nums.length; ++i) {
            expected ^= i;
        }

        for (int num : nums) {
            expected ^= num;
        }

        return expected;
    }
}