using System;

namespace LeetCodeChallenges._0026_RemoveDuplicates;

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0;
        // numero unico inicia em 1 porque sempre o primeiro elemento vai ser único
        int unique = 1;
        for(int i = 1; i < nums.Length; i++){
            // se o elemento é diferente do anterior ele é unico
            if (nums[i] != nums[i-1]){
                // a posição é sobrescrita com o valor unico na posição
                nums[unique] = nums[i];
                // incrementa a quantidade de unicos
                unique++;
            }
        }
        // retorno
        return unique;
    }
}