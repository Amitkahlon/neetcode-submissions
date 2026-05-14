public class Solution {
 public int[] TopKFrequent(int[] nums, int k)
 {
     Dictionary<int, int> count = new Dictionary<int, int>();

     List<int>[] freq = new List<int>[nums.Length + 1];

     for (int i = 0; i < nums.Length; i++)
     {
         if (count.ContainsKey(nums[i]))
         {
             count[nums[i]]++;
         }
         else
         {
             count.Add(nums[i], 1);
         }
     }

     foreach (var item in count)
     {
         if (freq[item.Value] == null)
         {
             freq[item.Value] = new List<int>();
         }


         freq[item.Value].Add(item.Key);
     }



     int[] result = new int[k];
     k--;

     for (int i = freq.Length - 1; i >= 0; i--)
     {
         var currList = freq[i];
         if (currList is null) continue;

         for (int b = 0; b < currList.Count; b++)
         {
             result[k] = currList[b];
             k--;
             if (k < 0) return result;
         }
     }

     return result;
 }
}
