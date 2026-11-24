public class Solution {
    public bool IsPalindrome(int x) {

        string textToFlip = x.ToString();
        string reversed = "";

        for (int i = textToFlip.Length - 1 ; i >= 0 ; i-- ){
            reversed += textToFlip[i];
        }

        return textToFlip == reversed;
    }
}