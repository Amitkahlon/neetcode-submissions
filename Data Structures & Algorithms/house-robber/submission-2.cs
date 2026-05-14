    public class Solution
    {
        public int Rob(int[] nums)
        {
            if(nums.Length == 1) return nums[0];

            int[] opt = new int[nums.Length];
            
            opt[0] = nums[0];
            opt[1] = Math.Max(nums[0], nums[1]);


            for (int i = 2; i < nums.Length; i++)
            {
                //#1 take current and add it to the i - 2
                //#2 dont take current, so copy from oi - 1

                if (nums[i] + opt[i - 2] > opt[i - 1])
                {
                    opt[i] = nums[i] + opt[i - 2];
                }
                else
                {
                    opt[i] = opt[i - 1];
                }
            }

            return opt.Last();
        }
    }

