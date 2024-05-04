public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int ans = 0, start = 0, end = people.Length - 1;
        while (start <= end) {
            if (people[start] + people[end] <= limit) {
                ++start;
            }

            --end;
            ++ans;
        }

        return ans;
    }
}