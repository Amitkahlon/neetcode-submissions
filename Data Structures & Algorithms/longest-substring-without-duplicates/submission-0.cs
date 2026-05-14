public class Solution {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0) return 0;

            HashSet<char> chars = new HashSet<char>();

            int l = 0;
            int r = 1;
            int maxSubstringCount = 1;

            chars.Add(s[0]);

            while (r < s.Length)
            {
                if (chars.Contains(s[r]))
                {
                    chars.Remove(s[l]);
                    l++;
                    continue;
                }

                chars.Add(s[r]);

                maxSubstringCount = Math.Max(r - l + 1, maxSubstringCount);
                r++;
            }

            return maxSubstringCount;
        }
}
