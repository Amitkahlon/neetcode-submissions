public class Solution {
    public int MaxArea(int[] heights)
    {
        int i = 0;
        int j = heights.Length - 1;

        int maxHeight = -1;

        while (i < j)
        {
            var height = Math.Min(heights[i], heights[j]);
            var width = j - i;
            var area = height * width;

            if (maxHeight < area)
            {
                maxHeight = area;
            }

            if (heights[i] > heights[j])
            {
                j--;
            }else
            {
                i++;
            }
        }

        return maxHeight;
    }

}
