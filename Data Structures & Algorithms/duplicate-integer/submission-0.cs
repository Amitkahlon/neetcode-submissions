public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        Dictionary<int, bool> dic = new Dictionary<int, bool>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(nums[i]))
            {
                return true;
            }

            dic.Add(nums[i], true);
        }

        return false;
    }
}