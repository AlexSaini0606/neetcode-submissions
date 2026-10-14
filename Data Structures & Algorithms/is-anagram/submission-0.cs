public class Solution {
    public bool IsAnagram(string s, string t) {
        string aa = String.Concat(s.OrderBy(c => c));
        string bb = String.Concat(t.OrderBy(c => c));

        if(aa == bb){
            return true;
        }

        return false;


    }
}
