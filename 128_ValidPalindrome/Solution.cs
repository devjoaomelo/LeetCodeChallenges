using System.Text.RegularExpressions;
public class Solution {
    public bool IsPalindrome(string s) {
        string result = Regex.Replace(s.ToLower(), @"[^a-zA-Z0-9]", "");

        int i = 0;
        int last = result.Length - 1;

        char j;
        char k;

        while (i < last){
            j = result[i];
            k = result[last];
            if(j != k){
                return false;
            }
            i++;
            last--;
        }
        return true;
        
    }
}