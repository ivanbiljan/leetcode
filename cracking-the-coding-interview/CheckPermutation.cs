public bool CheckPermutation(string original, string possiblePermutation) {
    var frequencies = new Dictionary<char, int>();
    foreach (var currentChar in original) {
        if (frequencies.ContainsKey(currentChar)) {
            ++frequencies[currentChar];
        } else {
            frequencies.Add(currentChar, 1);
        }
    }

    foreach (var currentChar in possiblePermutation) {
        if (!frequencies.ContainsKey(currentChar)) {
            return false;
        }

        if (--frequencies[currentChar] < 0) {
            return false;
        }
    }

    return true;
}