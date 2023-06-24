public class Solution {
    public bool IsPalindrome(string s) {
        if(string.IsNullOrWhiteSpace(s)) return true;

        s = s.ToLower();

        var chars = new List<char>();

        foreach(var chr in s) {
            if(chr >= 'a' && chr <= 'z' || char.IsDigit(chr)) {
                chars.Add(chr);
            }
        }

        int j = chars.Count() - 1;

        for(int i = 0; i < chars.Count() / 2; i++, j--) {
            if(chars[i] != chars[j]) return false;
        }

        return true;
    } 
}