using System;

public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        var maxWealth = -1;
        foreach (var i in accounts)
        {
            var summ = i.Sum();
            if (maxWealth < summ) {
                maxWealth = summ;
            }
        }

        return maxWealth;
    }
}