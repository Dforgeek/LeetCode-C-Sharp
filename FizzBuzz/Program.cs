using System;

public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        IList<string> answer = new List<string>();
        for (var i = 1; i <= n; i++)
        {
            var str = "";
            if (i % 3 == 0)
            {
                str += "Fizz";
            }

            if (i % 5 == 0)
            {
                str += "Buzz";
            }

            if (i % 5 != 0 && i % 3 != 0)
            {
                str += i;
            }

            answer.Add(str);
        }

        return answer;
    }
}