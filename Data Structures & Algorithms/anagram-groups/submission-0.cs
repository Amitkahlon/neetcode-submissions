public class Solution {
    public string ConvertToString(int[] charCount)
    {
        StringBuilder sb = new StringBuilder("");

        for (int i = 0; i < charCount.Length; i++)
        {
            sb.Append(charCount[i].ToString());
            sb.Append(' ');
        }

        return sb.ToString();
    }
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        List<int[]> ints = new List<int[]>();
        Dictionary<string, List<string>> keyValuePairs = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            var curr = strs[i];

            var arrCharCount = new int[26];
            ints.Add(arrCharCount);

            for (int j = 0; j < strs[i].Length; j++)
            {
                arrCharCount[curr[j] - 'a']++;
            }
        }

        for (int i = 0; i < ints.Count; i++)
        {
            var currentCharCount = ints[i];

            var hash = ConvertToString(ints[i]);
            if (keyValuePairs.TryGetValue(hash, out var strArr))
            {
                strArr.Add(strs[i]);
            }
            else
            {
                keyValuePairs.Add(hash, new List<string> { strs[i] });
            }
        }

        return keyValuePairs.Values.ToList();
    }
}
