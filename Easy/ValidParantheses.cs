public class Solution {
    public bool IsValid(string s) {
        if(s.Length % 2 != 0) return false;

        Stack<char> stk = new();

        foreach(char chr in s) {
            if(chr is '(' || chr is '{' || chr is '[') {
                stk.Push(chr);
            }
            else {
                if(stk is null || stk.Count() == 0) { 
                    return false;
                } else if (chr == ')' && stk.Peek() == '(') {
                    stk.Pop();
                } else if(chr == ']' && stk.Peek() == '[') {
                    stk.Pop();
                } else if(chr == '}' && stk.Peek() == '{'){
                    stk.Pop();
                } else {
                    return false;
                }
            }
        }

        if(stk.Count() == 0) return true;
        return false;
    }
}