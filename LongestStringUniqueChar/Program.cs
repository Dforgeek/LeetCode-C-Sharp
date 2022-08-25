using System;

public class Solution
{
    public static int LengthOfLongestSubstring(string s)
    {
        var dict = new Dictionary<char, int>();

        int maxLen = 0, lastInd = 0;


        for (var i = 0; i < s.Length; i++)
        {
            if (!dict.ContainsKey(s[i]))
            {
                dict.Add(s[i], i);
            }
            else
            {
                var lastIndNew = dict[s[i]] + 1;
                for (var j = lastInd; j < lastIndNew; j++)
                {
                    dict.Remove(s[j]);
                }

                lastInd = lastIndNew;
                dict.Add(s[i], i);
            }

            maxLen = (i - lastInd + 1) > maxLen ? i - lastInd + 1 : maxLen;
        }

        return maxLen;
    }


    public static void Main()
    {
        string s = "pwwkew";
        Console.WriteLine(LengthOfLongestSubstring(s));
    }
}