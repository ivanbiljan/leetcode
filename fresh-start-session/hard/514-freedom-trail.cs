public class Solution {
    private readonly Dictionary<char, List<int>> map = new();
    public int FindRotateSteps(string ring, string key) {
        for (var i = 0; i < ring.Length; ++i) {
            var indices = map.GetValueOrDefault(ring[i], new List<int>());
            indices.Add(i);
            map[ring[i]] = indices;
        }

        var cache = new int[key.Length, ring.Length];
        return Dfs(key, 0, ring, 0, cache);
    }

    public int Dfs(string key, int keyIndex, string ring, int ringOffsetIndex, int[,] cache) {
        if (keyIndex >= key.Length) {
            return 0;
        }

        if (cache[keyIndex, ringOffsetIndex] > 0) {
            return cache[keyIndex, ringOffsetIndex];
        }

        var indices = map[key[keyIndex]];

        var ans = int.MaxValue;
        foreach (var index in indices) {
            var rotations = Math.Min(
                ComputeCwShifts(ringOffsetIndex, index, ring.Length),
                ComputeCcwShifts(ringOffsetIndex, index, ring.Length));
            ans = Math.Min(ans, rotations + 1 + Dfs(key, keyIndex + 1, ring, index, cache));
        }

        cache[keyIndex, ringOffsetIndex] = ans;
        return ans;
    }

    private int ComputeCwShifts(int pos, int newPos, int ringLength) {
        if (newPos >= pos) {
            return newPos - pos;
        }

        return ringLength - (pos - newPos);
    }

    private int ComputeCcwShifts(int pos, int newPos, int ringLength) {
        if (pos >= newPos) {
            return pos - newPos;
        }

        return ringLength - (newPos - pos);
    }
}