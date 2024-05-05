public class Solution {
    public bool IsValid(string word) {
        if (word.Length < 3) {
            return false;
        }

        bool hasVowel = false, hasConsonant = false;
        foreach (var c in word) {
            if (!char.IsLetterOrDigit(c)) {
                return false;
            }

            if (!char.IsLetter(c)) {
                continue;
            }

            if (IsVowel(c)) {
                hasVowel = true;
            } else {
                hasConsonant = true;
            }
        }

        return hasVowel && hasConsonant;
    }

    private bool IsVowel(char c) {
        return char.ToLower(c) is 'a' or 'e' or 'i' or 'o' or 'u';
    }
}