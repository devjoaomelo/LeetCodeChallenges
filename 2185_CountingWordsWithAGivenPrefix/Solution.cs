using System;

namespace LeetCodeChallenges._2185_CountingWordsWithAGivenPrefix;

public class Solution {
    public int PrefixCount(string[] words, string pref) {
        int count = 0;
        for(int i = 0; i < words.Length; i++){
            if(words[i].StartsWith(pref)){
                count++;
            }
        }

        return count;
        
    }
}