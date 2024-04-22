public class Solution {
    public int OpenLock(string[] deadends, string target) {
        if (deadends.Contains("0000")) {
            return -1;
        }

        var ans = 0;
        var seen = new HashSet<string> {"0000"}; // List throws TLE
        var queue = new Queue<string>();

        queue.Enqueue("0000");
        while (queue.Count > 0) {
            var newCombinations = queue.Count;
            for (var i = 0; i < newCombinations; ++i) {
                var current = queue.Dequeue();
                if (deadends.Contains(current)) {
                    continue;
                }

                if (current == target) {
                    return ans;
                }

                for (var wheel = 0; wheel < current.Length; ++wheel) {
                    for (var dir = -1; dir <= 1; dir += 2) {
                        var currentChars = current.ToCharArray();
                        currentChars[wheel] = (char)('0' + (currentChars[wheel] - '0' + dir + 10) % 10);
                        var combo = new string(currentChars);
                        if (!seen.Contains(combo) && !deadends.Contains(combo)) {
                            seen.Add(combo);
                            queue.Enqueue(combo);
                        }    
                    }
                }
            }

            ++ans;
        }

        return -1;
    }
}