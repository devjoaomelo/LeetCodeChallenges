using System;

namespace LeetCodeChallenges._27_RemoveElement;

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if(nums.Length == 0) return 0;
        
        // elementos diferentes de k
        int k = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            // se for diferente de val, vai para a posição k para ordenar e sobrescreve o anterior
            if (nums[i] != val){
                nums[k] = nums[i];
                // incrementa a quantidade
                k++;
            }

        }
        // retorno
        return k;
    }
}