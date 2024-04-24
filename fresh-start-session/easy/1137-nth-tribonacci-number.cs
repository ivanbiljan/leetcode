public class Solution {
    public int Tribonacci(int n) {
        if (n == 0) {
            return 0;
        }

        if (n <= 2) {
            return 1;
        }

        var t0 = 0;
        var t1 = 1;
        var t2 = 1;

        for (var i = 0; i < n - 3; ++i) {
            var t2New = t0 + t1 + t2;
            t0 = t1;
            t1 = t2;
            t2 = t2New;
        }

        return t0 + t1 + t2;
    }
}