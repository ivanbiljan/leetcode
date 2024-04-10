public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        var ans = new List<IList<int>>();
        Backtrack(nums, 0, ans);
        return ans;        
    }

    public void Backtrack(int[] nums, int ix, IList<IList<int>> ans) {
        if (ix == nums.Length - 1) {
            ans.Add(nums.ToList());
            return;
        }

        for (var i = ix; i < nums.Length; ++i) {
            (nums[ix], nums[i]) = (nums[i], nums[ix]);
            Backtrack(nums, ix + 1, ans);
            (nums[ix], nums[i]) = (nums[i], nums[ix]);
        }
    }
}