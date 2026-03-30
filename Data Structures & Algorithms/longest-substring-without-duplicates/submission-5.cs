public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s==" ") return 1;
        int l=0 , r=0;
        int result = 0;
        HashSet<char> temp = new HashSet<char>();
        while(r<s.Length){
            if(temp.Contains(s[r])){
                temp.Remove(s[l]);
                l++;
            }
            else{
                temp.Add(s[r]);
                result = result>=temp.Count() ? result : temp.Count();
                r++;
            }   
        }
        return result;
    }

}
