public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        var n = nums.Length;
        HashSet<int> ints = new HashSet<int>();

        int smallest = int.MaxValue;
        int biggest = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            var curr = nums[i];
            ints.Add(curr);
            if (curr < smallest) smallest = curr;
            if (curr > biggest) biggest = curr;
        }

        int maxCounter = 0;
        int currCounter = 0;
        for (int i = smallest; i <= biggest; i++)
        {
            if (ints.TryGetValue(i, out var actual))
            {
                currCounter++;
            }
            else
            {
                if (maxCounter < currCounter) maxCounter = currCounter;
                currCounter = 0;
            }

            if (maxCounter < currCounter) maxCounter = currCounter;
        }

        return maxCounter;
    }
}
