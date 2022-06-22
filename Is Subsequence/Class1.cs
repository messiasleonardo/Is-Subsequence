namespace Is_Subsequence
{
    public class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            if (string.IsNullOrEmpty(s)) return true;

            Dictionary<string, char> map = new Dictionary<string, char>();
            string addCharToString = "";
            int index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = index; j < t.Length; j++)
                {
                    if (s[i] == t[j])
                    {
                        index = j+1;
                        addCharToString += $"{s[i]}";
                        map[addCharToString] = t[j];
                        if (j == t.Length -1)
                        {
                            if (map.ContainsKey(s))
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        break;
                    }
                }
            }
            if (map.ContainsKey(s))
            {
                return true;
            }

            return false;
        }
    }
}