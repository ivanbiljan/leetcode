public class Solution {
    public int LengthOfLastWord(string s) {
        return s.Split(' ', StringSplitOptions.RemoveEmptyEntries)[^1].Length;
    }
}