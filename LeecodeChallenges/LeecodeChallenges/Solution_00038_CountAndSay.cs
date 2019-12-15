using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution_00038_CountAndSay
{
    public string CountAndSay(int n)
    {
        var result = "1";
        for(var i=1; i<n; i++)
        {
            result = Calculate(result);
        }

        return result;
    }

    private string Calculate(string s)
    {
        var listKey = new List<char>() { s[0] };
        var listVal = new List<int>();
        var lastKey = s[0];
        var lastVal = 1;
        for (var i=1; i<s.Length; i++)
        {
            var c = s[i];
            if(c == lastKey)
            {
                lastVal++;
            }
            else
            {
                listKey.Add(c);
                listVal.Add(lastVal);
                lastKey = c;
                lastVal = 1;
            }
        }
        listVal.Add(lastVal);

        var cnt = listKey.Count;
        StringBuilder sb = new StringBuilder();
        for(var i=0; i<cnt; i++)
        {
            sb.Append(listVal[i]);
            sb.Append(listKey[i]);
        }
        return sb.ToString();
    }

}