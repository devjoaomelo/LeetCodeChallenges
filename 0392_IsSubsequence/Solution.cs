using System;

namespace LeetCodeChallenges._0392_IsSubsequence;

public class Solution {
    public bool IsSubsequence(string s, string t) {
        int pos = 0;
        for(int i = 0; i < t.Length && pos < s.Length; i++){
            if(t[i] == s[pos]){
                pos++;
            }
        }
        return pos == s.Length;
    }
}