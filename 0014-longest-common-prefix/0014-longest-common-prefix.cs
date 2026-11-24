public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string shortest = strs.MinBy(s => s.Length);

        string longestComPrefix = "";

        for (int i = 0; i < shortest.Length; i++){
            for (int j = 0; j < strs.Length; j++){
                if (shortest[i] == strs[j][i]){
                    continue;
                } else {
                    return longestComPrefix;
                }
            }
            longestComPrefix += shortest[i];
        }

        return longestComPrefix;
    }
}