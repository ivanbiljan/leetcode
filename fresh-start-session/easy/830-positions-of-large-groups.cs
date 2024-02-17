public class Solution {
    public IList<IList<int>> LargeGroupPositions(string s) {
        var result = new List<IList<int>>();
        var startIndex = 0;
        for (var i = 1; i < s.Length; ++i) {
            if (s[i] != s[i - 1]) {
                if (i - startIndex >= 3) {
                    result.Add(new List<int> {startIndex, i - 1});
                }

                startIndex = i;
            }
        }

        if (s.Length - startIndex >= 3) {
            result.Add(new List<int> {startIndex, s.Length - 1});
        }

        return result;
    }
}