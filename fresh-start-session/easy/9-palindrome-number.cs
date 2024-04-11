public class Solution {
    public bool IsPalindrome(int x) {
        // if (x < 0) {
        //     return false;
        // }

        // var digitCnt = (int) Math.Floor(Math.Log10(x)) + 1;
        // for (var i = 0; i < digitCnt / 2; ++i) {
        //     var start = (x / (int) Math.Pow(10, digitCnt - 1 - i)) % 10;
        //     var end = (x / (int) Math.Pow(10, i)) % 10;

        //     if (start != end) {
        //         return false;
        //     }
        // }

        // return true;
        if (x < 0) {
            return false;
        }

        int reversed = 0, temp = x;
        while (temp > 0) {
            reversed = reversed * 10 + temp % 10;
            temp /= 10;
        }

        return reversed == x;
    }
}