public class Solution {

    public string Encode(IList<string> strs)
    {
        StringBuilder sb = new StringBuilder();

        foreach (string str in strs)
        {
            var strLength = str.Length;
            sb.Append(strLength.ToString());
            sb.Append("#");
            sb.Append(str);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s)
    {
        List<string> strs = new List<string>(); 
        int j = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '#')
            {
                //0123
                var digitLength = i - j;
                var charCount = int.Parse(s.Substring(j, digitLength));
                strs.Add(s.Substring(i + 1, charCount));
                var nextDigitIndex = i + charCount;
                j = i + charCount + 1;
                i = i + charCount + 1;
            }
        }

        return strs;
    }
}
