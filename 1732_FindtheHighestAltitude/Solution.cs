using System;

namespace LeetCodeChallenges._1732_FindtheHighestAltitude;

public class Solution {
    public int LargestAltitude(int[] gain) {
        int count = 0;
        int ans = 0;
        for(int i = 0; i < gain.Length; i++){
            count+=gain[i];
            if(count > ans) {
                ans = count;
            }

        }
        return ans;        
    }
}