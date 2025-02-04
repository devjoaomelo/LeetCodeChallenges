using System;

namespace LeetCodeChallenges._0035_SearchInsertPosition;

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        // recebe o index ou retorna -1
        int idx = Array.IndexOf(nums, target);
        if(idx != -1){
            // se for diferente de -1 achou
            return idx;
        }
        // se for maior que o ultimo elemento retorna como o proximo elemento
        if(target > nums[nums.Length-1]){
            return nums.Length;

        }
        // percorrendo para ver se é maior que o elemento anterior
        for(int i = nums.Length - 1; i >= 0; i--){
            if(nums[i] < target){
                return i + 1;
            }
            
        }
        return 0;
    }
}