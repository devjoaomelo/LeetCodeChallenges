using System;

namespace LeetCodeChallenges._1475_FinalPricesWithASpecialDiscountInAShop;

public class Solution {
    public int[] FinalPrices(int[] prices){
        // validação simples se o index i+1 é menor que o index i para aplicar o desconto, caso não ou se for o ultimo mantém o valor quebrano o laço
        for(int i = 0; i < prices.Length; i++){
            for(int j = i+1; j < prices.Length; j++){
                if(prices[j] <= prices[i]){
                    prices[i] -= prices[j];
                    break;
                }
            }
        }
        return prices;
    }
}