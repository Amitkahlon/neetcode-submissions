public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();


        for (int i = 0; i < nums.Length; i++)
        {
            dic.TryAdd(nums[i], i);
        }


        for (int indexNum1 = 0; indexNum1 < nums.Length; indexNum1++)
        {
            int num1 = nums[indexNum1];
            var wantedNum2 = target - num1;

            if (dic.TryGetValue(wantedNum2, out var indexNum2))
            {
                if (indexNum2 == indexNum1)
                {
                    continue;
                }

                if (indexNum2 > indexNum1)
                {
                    return new int[] { indexNum1, indexNum2 };
                }
                else
                {
                    return new int[] { indexNum2, indexNum1 };
                }
            }
        }

        return null;
    }


}