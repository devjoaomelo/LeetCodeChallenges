using System;
using System.Collections;
using System.Text;

namespace LeetCodeChallenges._0345_ReverseVowelsOfaString;

public class Solution {
    public string ReverseVowels(string s) {
        StringBuilder ans = new StringBuilder();
        Stack vowels = new Stack();
        string validVowels = "AaEeIiOoUu";

        foreach(var item in s){
            if(validVowels.Contains(item)){
                vowels.Push(item);
            }
        }

        foreach (var item in s){
            if(validVowels.Contains(item)){
                ans.Append(vowels.Peek());
                vowels.Pop();
                continue;
            }
            ans.Append(item);    
        }
        return ans.ToString();
    }
}
