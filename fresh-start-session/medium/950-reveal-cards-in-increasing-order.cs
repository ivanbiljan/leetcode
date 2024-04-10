public class Solution {
    public int[] DeckRevealedIncreasing(int[] deck) {
        Array.Sort(deck);
        var ans = new int[deck.Length];
        var order = Enumerable.Range(0, deck.Length).ToList();

        for (var i = 0; i < deck.Length; ++i) {
            ans[order[0]] = deck[i];
            order.RemoveAt(0);
            if (order.Count > 0) {
                var top = order[0];
                order.RemoveAt(0);
                order.Add(top);
            }
        }

        return ans;
    }
}