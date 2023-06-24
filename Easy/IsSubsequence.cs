public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(s is "") return true;

        int j = 0;
        for(int i = 0; i < t.Length && j < s.Length; i++) {
            if(t[i] == s[j]) j++;
        }

        return j == s.Length;
    }
}