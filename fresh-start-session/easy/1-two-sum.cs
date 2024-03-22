public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var complements = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; ++i) {
            if (complements.TryGetValue(target - nums[i], out var complementIndex)) {
                return new int[] {complementIndex, i};
            }

            complements[nums[i]] = i;
        }

        return null;
    }
}