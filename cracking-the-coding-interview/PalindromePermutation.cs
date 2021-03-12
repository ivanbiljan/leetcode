public sealed class Solution {
    public bool IsPalindromePermutation(string input) {
        var map = new Dictionary<char, int>(); // Frequency mapping
        foreach (var character in input) {
            ++map[character];
        }

        var numberOfOdds = 0;
        foreach (var (_, frequency) in map) {
            if (frequency % 2 == 0) {
                ++numberOfOdds;
            }
        }

        return numberOfOdds <= 1;
    }
}