public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        // var freq = new Dictionary<int, int>();
        // foreach (var num in nums) {
        //     if (freq.ContainsKey(num)) {
        //         freq[num]++;
        //     } else {
        //         freq[num] = 1;
        //     }
        // }
        
        // return freq.Where(kvp => kvp.Value > 1).Select(kvp => kvp.Key).ToList();
        var result = new List<int>();
        for (var i = 0; i < nums.Length; ++i) {
            if (nums[Math.Abs(nums[i]) - 1] < 0) {
                result.Add(Math.Abs(nums[i]));
            } else {
                nums[Math.Abs(nums[i]) - 1] *= -1;
            }
        }

        return result;
    }