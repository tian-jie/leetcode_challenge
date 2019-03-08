using System.Linq;

public class Solution00136
{
    public int SingleNumber(int[] nums)
    {
        var newNums = nums.OrderBy(a => a).ToArray();
        var result = newNums[0];
        for(var i=1; i<newNums.Count(); i++)
        {
            if(newNums[i] != nums[i-1] && newNums[i] != nums[i + 1])
            {
                result = newNums[i];
                break;
            }
        }

        return result;
    }
}