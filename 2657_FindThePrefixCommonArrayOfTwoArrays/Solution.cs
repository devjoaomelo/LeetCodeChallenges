using System;

namespace LeetCodeChallenges._2657_FindThePrefixCommonArrayOfTwoArrays;

public class Solution {
    public int[] FindThePrefixCommonArray(int[] A, int[] B) {
        // HashSet só aceita valores únicos
        HashSet<int> set = new HashSet<int>();
        int[] ans = new int[A.Length];
        int count = 0;

        for(int i = 0; i < A.Length; i++){
            // Se falhar em adicionar o valor ao set (repetido) aumenta o count
            if(!set.Add(A[i])){
                count++;
            }
            if(!set.Add(B[i])){
                count++;
            }
            ans[i] = count;
        }
        
        return ans;
    }
}