using System.Linq;

public class Solution_00136_SingleNumber
{
    public int SingleNumber(int[] nums)
    {
        var newNums = nums.OrderBy(a => a).ToArray();
        var result = newNums[0];
        var cnt = nums.Length;
        for (var i = 1; i < cnt; i++)
        {
            if (i == cnt - 1 && newNums[i] != newNums[i - 1])
            {
                result = newNums[i];
                break;
            }
            else if (newNums[i] != newNums[i - 1] && newNums[i] != newNums[i + 1])
            {
                result = newNums[i];
                break;
            }
        }

        return result;
    }
}