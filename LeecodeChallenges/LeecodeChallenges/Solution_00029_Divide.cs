using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution_00029_Divide
{
    public int Divide(int dividend, int divisor)
    {
        var isOver = 0;
        if (dividend == -2147483648 && divisor == -2147483648)
        {
            return 1;
        }
        else if (dividend != -2147483648 && divisor == -2147483648)
        {
            return 0;
        }

        if (dividend == -2147483648)
        {
            dividend = -2147483647;
            isOver = 1;
        }
        if (dividend == 0)
        {
            return 0;
        }

        var sign = -1;
        if ((dividend > 0 && divisor > 0) || (dividend < 0 && divisor < 0))
        {
            sign = 1;
        }

        if (dividend < 0)
        {
            dividend = -dividend;
        }

        if (divisor < 0)
        {
            divisor = -divisor;
        }

        // 建立一个数组，存1n,2n,4n,8n,16n.....的数字
        var divArray = new Dictionary<int, int>();
        divArray[1] = divisor;
        var maxArrayIndex = 1;
        var maxArrayNumber = divisor;

        while (maxArrayNumber <= 1073741823 && maxArrayNumber < dividend)
        {
            maxArrayNumber = divArray[maxArrayIndex] + divArray[maxArrayIndex];
            maxArrayIndex = maxArrayIndex << 1;
            divArray[maxArrayIndex] = maxArrayNumber;
        }

        var cnt = 0;
        // 从大到小来扣减
        //while (dividend > 0)
        {
            foreach (var key in divArray.Keys.OrderByDescending(a => a))
            {
                var value = divArray[key];
                while (dividend >= value)
                {
                    dividend -= value;
                    cnt += key;
                }
            }
        }

        dividend += isOver;

        if (dividend >= divisor)
        {
            dividend -= divisor;
            if (cnt == 2147483647 && sign == -1)
            {
                return -2147483648;
            }
            else if (cnt == 2147483647 && sign == 1)
            {
                return 2147483647;
            }
            cnt++;
        }
        return sign > 0 ? cnt : -cnt;
    }
}