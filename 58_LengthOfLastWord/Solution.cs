using System;

namespace LeetCodeChallenges._58_LengthOfLastWord;

public class Solution {
    public int LengthOfLastWord(string s) {
        string[] words = s.Split(new char[]{ ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string x = words[words.Length - 1];
        return x.Length;
    }
}
