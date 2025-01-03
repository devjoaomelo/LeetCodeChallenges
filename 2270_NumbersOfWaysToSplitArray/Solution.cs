using System;

namespace LeetCodeChallenges._2270_NumbersOfWaysToSplitArray;

public class Solution {
    public int WaysToSplitArray(int[] nums) {
        // precisa ser long devido ao caso
        long somaEsquerda = 0, somaDireita = 0;
        foreach (var num in nums)
        {
            // separar a soma total do array
            somaDireita +=num;
        }
        // acumulador de válidos
        int splitsValidos = 0;

        for (int i = 0; i < nums.Length-1; i++)
        {
            // passa o elemento atual para outra variável e subtrai o mesmo do separador
            somaEsquerda += nums[i];
            somaDireita -= nums[i];

            // caso o elemento ou a soma for maior que o restante é um split válido
            if(somaEsquerda >= somaDireita){
                splitsValidos++;
            }
        }
        // retorno
        return splitsValidos; 
    }
}