using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution_00032_LongestValidParentheses
{
    public int LongestValidParentheses(string s)
    {
        if(s.Length == 0)
        {
            return 0;
        }

        var nums = new int[s.Length];
        for(var i=0;  i<s.Length; i++)
        {
            nums[i] = 0;
        }

        var ss = new Stack<char>();
        var index = 0;
        var indexList = new Stack<int>();
        foreach (var c in s)
        {
            if (c == '(')
            {
                ss.Push(c);
                indexList.Push(index);
            }
            else
            {
                if(ss.Count>0 && ss.Last() == '(')
                {
                    ss.Pop();
                    // 拿出对应的上一个(的index
                    var lastIndex = indexList.Pop();
                    var length = index - lastIndex + 1;

                    if(lastIndex>0 && nums[lastIndex - 1] > 1)
                    {
                        length += nums[lastIndex - 1];
                    }
                    nums[index] = length;
                }
            }

            index++;
        }

        return nums.Max();
    }


}