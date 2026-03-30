public class Solution {
    public int CharacterReplacement(string s, int k) {
        int result = 0;
    var match = new Dictionary<char, int>();
    int l = 0, maxCount = 0;

    for (int r = 0; r < s.Length; r++)
    {
        if (!match.ContainsKey(s[r]))
            match[s[r]] = 0;
        match[s[r]]++;

        // Track the most frequent char in the current window
        maxCount = Math.Max(maxCount, match[s[r]]);

        // If we need more than k changes, shrink window from left
        while ((r - l + 1) - maxCount > k)
        {
            match[s[l]]--;
            l++;
        }

        result = Math.Max(result, r - l + 1);
    }

    return result;
    }
}
