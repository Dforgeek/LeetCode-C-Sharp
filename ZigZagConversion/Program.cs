using System;

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
        {
            return s;
        }
        var answer = new char[s.Length];
        var indCnt = 0;
        for (var i = 0; i < s.Length; i += (2 * numRows) - 2)
        {
            answer[indCnt++] = s[i];
        }

        for (var j = 1; j < (numRows - 1); j++)
        {
            for (var i = j; i < s.Length; i += (2 * numRows) - 2)
            {
                answer[indCnt++] = s[i];
                if (i + 2 * (numRows - j - 1) < s.Length)
                {
                    answer[indCnt++] = s[i + 2 * (numRows - j - 1)];
                }
            }
        }
        
        for (var i = numRows-1; i < s.Length; i += (2 * numRows) - 2)
        {
            answer[indCnt++] = s[i];
        }
        var realAnswer = new string(answer);
        return realAnswer;
    }

    public static void Main()
    {
        //Console.WriteLine(Converte("PAYPALISHIRING", 3)=="PAHNAPLSIIGYIR");
        //Console.WriteLine(Converte("PAYPALISHIRING", 4)=="PINALSIGYAHRPI");
        Console.WriteLine(Converte("A", 1));
    }
};