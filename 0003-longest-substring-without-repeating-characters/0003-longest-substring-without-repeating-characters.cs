public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (string.IsNullOrEmpty(s)) return 0;

        var last = new int[128];
        int left = 0;
        int best = 0;

        for (int right = 0; right < s.Length; right++)
        {
            char c = s[right];

            left = Math.Max(left, last[c]);    

            best = Math.Max(best, right - left + 1);

            last[c] = right + 1;

        }

        return best;
    }
}