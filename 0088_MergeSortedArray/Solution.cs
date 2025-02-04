using System;

namespace LeetCodeChallenges._0088_MergeSortedArray;

public class Solution
{    
    public void Merge(int[]nums1, int m, int[]nums2, int n)
    {
        int lastIdx = m + n - 1;
        int size1 = m - 1;
        int size2 = n - 1;

        while(size2 >= 0){
            if(size1 >= 0 && nums1[size1] > nums2[size2]){
                nums1[lastIdx] = nums1[size1];
                size1--;
            }
            else{
                nums1[lastIdx] = nums2[size2];
                size2--;
            }
            lastIdx--;
        }
    }

}
