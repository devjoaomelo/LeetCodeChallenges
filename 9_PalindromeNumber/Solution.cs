namespace LeetCodeChallenges._9_PalindromeNumber;

public class Solution {
    public bool IsPalindrome(int x) {
        string k = x.ToString();
        for(int i = 0; i < k.Length/2; i++){
            if(k[i] != k[k.Length-1-i]){
                return false;
            }
            
        }
        return true;
        
    }
}