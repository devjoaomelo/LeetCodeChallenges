using System;

namespace LeetCodeChallenges._2342_MaxSumOfaPairWithEqualSumOfDigits
{
    class Solution
    {
        static void Main(string[] args)
        {     
            int ans =  new Solution().maximumSum(new int[] { 18, 43, 36, 13, 7 });
            Console.WriteLine(ans);
        }

        public int maximumSum(int[] nums)
        {
            int maxSum = -1;
            Dictionary<int, int> hash = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                int sumDigits = GetSum(num);
                if (hash.ContainsKey(sumDigits))
                {
                    maxSum = Math.Max(maxSum, hash[sumDigits] + num);
                    hash[sumDigits] = Math.Max(hash[sumDigits], num);
                }
                else
                {
                    hash.Add(sumDigits, num);
                }

            }
            return maxSum;
        }

        private int GetSum(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;  
            }
            return sum;
        }
    }
}