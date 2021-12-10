using System.Linq;
using System.Collections.Generic;
using System.Text;

public class Solution_01480_RunningSumOf1dArray
{
    public int[] RunningSum(int[] nums)
    {
        for (var i = 1; i < nums.Length; i++)
        {
            nums[i] = nums[i] + nums[i - 1];
        }
        return nums;
    }
}