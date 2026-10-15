public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var group = new Dictionary<string, List<string>>();
        if(strs.Length == 0){
            return new List<List<string>>();
        }
        foreach(string str in strs){
            int[] count = new int[26];
            foreach(char character in str){
                count[character - 'a']++;
            }
            StringBuilder sb = new();
            for(int i = 0; i < 26; i++){
                sb.Append("#");
                sb.Append(count[i]);

            }
            string key = sb.ToString();
            if(!group.ContainsKey(key)){
                group[key] = new List<string>();
            }

            group[key].Add(str);
        }
        return new List<List<string>>(group.Values);



        
    }
}
