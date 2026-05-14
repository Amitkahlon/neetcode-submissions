public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        var inverseComparer = Comparer<int>.Create((a, b) => 0 - a.CompareTo(b));
        var heap = new PriorityQueue<int, int>(inverseComparer);

        Dictionary<int, int> dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(nums[i]))
            {
                dic[nums[i]]++;
            }
            else
            {
                dic.Add(nums[i], 1);
            }
        }

       foreach (var item in dic)
       {
           heap.Enqueue(item.Key, item.Value);
       }


        int[] result = new int[k];

        for (int i = 0; i < k; i++)
        {
            var r = heap.Dequeue(); 
            result[i] = r;
        }

        return result;
    }
}
