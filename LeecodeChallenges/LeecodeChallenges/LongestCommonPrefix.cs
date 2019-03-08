using System.Linq;

public class Solution00014
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
        {
            return "";
        }
        if (strs.Length == 1)
        {
            return strs[0];
        }

        //以最短的字符串为标准
        var commonStr = strs.OrderBy(a => a.Length).FirstOrDefault();

        for (var strIndex = 0; strIndex < strs.Length; strIndex++)
        {
            var str = strs[strIndex];
            for (var i = 0; i < commonStr.Length; i++)
            {
                if (str[i] != commonStr[i])
                {
                    commonStr = commonStr.Substring(0, i);
                    break;
                }
            }
        }

        return commonStr;

    }
}