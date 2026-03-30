public class Solution {
    public bool IsPalindrome(string s) {
        string newString = new string(s.Where(char.IsLetterOrDigit).ToArray());
        newString = newString.ToLower();
        for(int i =0 ; i<newString.Length/2;i++){
            for(int j=newString.Length-i-1 ;j>=(newString.Length/2);j--){
                if(newString[i] == newString[j]){
                    break;
                }
                return false;
            }
        }
        return true;
    }
}
