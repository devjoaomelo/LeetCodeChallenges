using System;

namespace LeetCodeChallenges._0724_FindPivotIndex;

public class Solution {
    public int PivotIndex(int[] nums) {
        int numsSum = 0;
        int leftSum = 0;

        // para evitar usar nums.Sum();
        foreach(int num in nums){
            numsSum += num;
        }

        // percorrer para encontrar o pivô
        for(int i = 0; i< nums.Length; i++){
            int current = nums[i];
            if(leftSum == numsSum - leftSum - current) return i;
            leftSum += current;
        }
        return -1;
    }
}