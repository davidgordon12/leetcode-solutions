public class Solution {
    public int MinSwaps(string s) {
        int extraParen = 0;
        int swaps = 0;
        for(int i = 0; i < s.Length; i++) {
            if(s[i] == '[') {
                extraParen--;
            } else {
                extraParen++;
                swaps = Math.Max(swaps, extraParen);
            }
        }

        // each swap removes 2 extraParen, decreasing our total swaps by 1
        return (swaps+1)/2;
    }
}