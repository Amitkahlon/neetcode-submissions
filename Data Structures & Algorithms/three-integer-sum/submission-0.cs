public class Solution {
    public List<List<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        List<List<int>> triplets = new List<List<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i - 1] == nums[i]) continue;

            int l = i + 1;
            int r = nums.Length - 1;

            while (l < r)
            {
                var currSum = nums[l] + nums[r] + nums[i];

                if (currSum == 0)
                {
                    triplets.Add(new List<int> { nums[i], nums[l], nums[r] });
                    l++;
                    while (nums[l] == nums[l - 1] && l < r)
                    {
                        l++;
                    }
                }

                else if (currSum > 0)
                {
                    r--;
                }
                else
                {
                    l++;
                }
            }
        }

        return triplets;
    }

}
