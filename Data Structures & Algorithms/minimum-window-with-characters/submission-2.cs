public class Solution {
        public string MinWindow(string s, string t)
        {
            int ARRAY_LENGTH = 77;
            int[] shouldInclude = new int[ARRAY_LENGTH];

            foreach (var tChar in t)
            {
                shouldInclude[tChar - 'A']++;
            }

            int l = 0;
            int r = 0;

            int minL = -1;
            int minR = s.Length;

            int[] currentInclude = new int[ARRAY_LENGTH];

            while (r < s.Length && l <= r)
            {
                int leftI = s[l] - 'A';
                int rightI = s[r] - 'A';

                currentInclude[rightI]++;

                bool vaild = true;

                for (int i = 0; i < ARRAY_LENGTH; i++)
                {
                    if (shouldInclude[i] > currentInclude[i])
                    {
                        vaild = false;
                        break;
                    }
                }

                if (vaild)
                {
                    if (r - l < minR - minL)
                    {
                        minL = l;
                        minR = r;
                    }

                    currentInclude[leftI]--;
                    currentInclude[rightI]--; //to ignore double increment
                    l++;
                }
                else
                {
                    r++;
                }
            }
            if (minL == -1) return "";

            return s[minL..(minR + 1)];
        }}
