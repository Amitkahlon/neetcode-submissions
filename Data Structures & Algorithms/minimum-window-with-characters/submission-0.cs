public class Solution {
        public string MinWindow(string s, string t)
        {
            int ARRAY_LENGTH = 60;
            int[] shouldInclude = new int[ARRAY_LENGTH];

            foreach (var tChar in t)
            {
                shouldInclude[tChar - 'A']++;
            }


            if (!IsInclude(s) || t.Length == 0) return "";

            return IsIncludeRecursiv(s);

            string IsIncludeRecursiv(string str)
            {
                if (str.Length < t.Length || str.Length <= 0 || !IsInclude(str))
                {
                    return s + "BLA BLA";
                }

                if(str.Length == 1)
                {
                    return IsInclude(str) ? str : s + "BLA BLA";
                }

                var str1 = str.Substring(0, str.Length - 1);
                var str2 = str.Substring(1, str.Length - 1);

                var a = IsIncludeRecursiv(str1);
                var b = IsIncludeRecursiv(str2);

                return new string[] { a, b, str }.OrderBy(x => x.Length).First();
            }

            bool IsInclude(string str)
            {
                int[] currentInclude = new int[ARRAY_LENGTH];

                foreach (var sChar in str)
                {
                    currentInclude[sChar - 'A']++;
                }

                for (int i = 0; i < ARRAY_LENGTH; i++)
                {
                    if (shouldInclude[i] > currentInclude[i])
                    {
                        return false;
                    }
                }

                return true;
            }

        }
}
