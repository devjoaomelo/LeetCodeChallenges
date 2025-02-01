using System;

namespace LeetCodeChallenges._3151_SpecialArrayI;

public class Solution {
    public bool IsArraySpecial(int[] nums) {
        int i = 0;
        int j = 1;
        int size = nums.Length;
        if(size > 1){
            while(i < size - 1 && j < size){
                if(nums[i] % 2 == 0 && nums[j] % 2 != 0 || nums[i] % 2 != 0 && nums[j] % 2 == 0){
                    i++;
                    j++;
                    continue;
                }
                return false;
            }
        }
        return true;
    }
}
