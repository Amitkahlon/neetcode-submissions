public class Solution
{

    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        int[] charCount = new int[150];


        for (int i = 0; i < s.Length; i++)
        {
            var charCodeS = s[i].GetHashCode() % charCount.Length;
            charCount[charCodeS]++;

            var charCodeT = t[i].GetHashCode() % charCount.Length;
            charCount[charCodeT]--;
        }

        for (int i = 0; i < charCount.Length; i++)
        {
            if (charCount[i] != 0)
            {
                return false;
            }
        }

        return true;

    }
}