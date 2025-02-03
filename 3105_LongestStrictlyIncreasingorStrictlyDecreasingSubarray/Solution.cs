using System;

namespace LeetCodeChallenges._3105_LongestStrictlyIncreasingorStrictlyDecreasingSubarray;

public class Solution {
    public int LongestMonotonicSubarray(int[] nums){
        if(nums.Length == 1) return 1;
        int maxLength = 1;
        int countA = 1;
        int countB = 1;

        for(int i = 1; i<nums.Length; i++){
            if(nums[i] < nums[i-1]){
                countA++;
                countB = 1;
            } else if (nums[i] > nums[i-1]){
                countB++;
                countA = 1;
            }
            else {
                countA = 1;
                countB = 1;
            }
            maxLength = Math.Max(maxLength, Math.Max(countA, countB));

        }
        return maxLength;
    }
}