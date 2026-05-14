public class Solution {
        public int CharacterReplacement(string s, int k)
        {
            if (s.Length == 1) return 1;

            int[] charsCount = new int[27];

            int l = 0;
            int r = 0;
            int max = 0;

            while (r < s.Length)
            {
                charsCount[s[r] - 'A']++;
                //AAABABB
                var maxCount = charsCount.Max();
                var total = charsCount.Sum();
                bool isValid = total - maxCount <= k;

                if (isValid)
                {
                    max = Math.Max(max, total);
                    r++;
                }
                else
                {
                    charsCount[s[l] - 'A']--;
                    charsCount[s[r] - 'A']--;
                    l++;
                }
            }

            return max;

        }







}
