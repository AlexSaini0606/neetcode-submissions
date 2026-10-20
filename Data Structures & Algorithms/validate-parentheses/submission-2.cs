public class Solution {
    public bool IsValid(string s) {
        Stack<char> charStack = new Stack<char>();

        foreach(char c in s){
            
            if(c == '(' || c == '[' || c == '{'){
                charStack.Push(c);
            } else if(charStack.Count == 0){
                return false;
            }
            else if(c == ')' && charStack.Peek() == '('){
                charStack.Pop();
            } else if(c == ']' && charStack.Peek() == '['){
                charStack.Pop();
            }
            else if(c == '}' && charStack.Peek() == '{'){
                charStack.Pop();
            } else{
                return false;
            }
        

        }
        return charStack.Count == 0;

    }
}
