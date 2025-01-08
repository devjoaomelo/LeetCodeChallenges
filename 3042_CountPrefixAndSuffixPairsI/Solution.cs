using System;

namespace LeetCodeChallenges._3042_CountPrefixAndSuffixPairsI;

public class Solution {
    private bool IsPrefixAndSuffix(string str1, string str2){
        int size1 = str1.Length, size2 = str2.Length;
        if(size1 > size2) return false;
        
        return str2.Substring(0, size1) == str1 && str2.Substring(size2 - size1) == str1;
    }
    public int CountPrefixSuffixPairs(string[] words) {
        int pairsCount = 0;
        for(int i = 0; i < words.Length; i++){
            for(int j = i + 1; j < words.Length; j++){
                if(IsPrefixAndSuffix(words[i], words[j])){
                    pairsCount++;
                }
            }
        }
        return pairsCount;
    }
}