using System;

namespace LeetCodeChallenges._1431_KidsWiththeGreatestNumberofCandies;

public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        bool[] ans = new bool[candies.Length];
        int greatest = 0;

        for(int i = 0; i< candies.Length; i++){
            if(greatest < candies[i]){
                greatest = candies[i];
            }
        }
        for(int i = 0; i < candies.Length; i++){
            ans[i] = candies[i] + extraCandies >= greatest;
        }
        return ans;
    }

}
