using System;
using System.Text;

namespace LeetCodeChallenges._0001_TwoSum;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> hash = new Dictionary<int,int>();
        for (int i = 0; i < nums.Length; i++){
            int append = target - nums[i];
            if(hash.ContainsKey(append)){
                return new int[]{hash[append], i};
            }

            hash[nums[i]] = i;
        }
        return new int[]{ -1, -1};   
    }
}
