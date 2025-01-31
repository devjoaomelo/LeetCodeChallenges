using System.Text;

namespace LeetCodeChallenges._1768_MergeStringsAlternately;

public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder ans = new StringBuilder();
        int i = 0;
        int j = 0;

        while(i < word1.Length && j < word2.Length){
            ans.Append(word1[i]);
            ans.Append(word2[j]);
            i++;
            j++;
        }

        while(i < word1.Length){
            ans.Append(word1[i]);
            i++;
        }

        while(j < word2.Length){
            ans.Append(word2[j]);
            j++;
        }

        return ans.ToString();        
    }
}
