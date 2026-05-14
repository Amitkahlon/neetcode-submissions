public class Solution {
        public int MaxSubArray(int[] nums)
        {
            int max = nums[0];
            int currSum = 0;
            int i = 0;

            foreach (int n in nums)
            {
                if (currSum < 0)
                {
                    currSum = 0;
                }

                currSum += n;

                max = Math.Max(currSum, max);
            }

            return max;
        }
}
