public class Solution {
        public int FindMin(int[] nums)
        {
            int n = nums.Length;
            int l = 0;
            int r = n - 1;
            int result = int.MaxValue;

            while (l <= r)
            {
                int mid = (l + r) / 2;



                if (nums[l] <= nums[r])
                {
                    result = Math.Min(result, nums[l]);
                    break;
                }
                     result = Math.Min(result, nums[mid]);
                if (nums[l] <= nums[mid])
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }

            return result;
        }
}
