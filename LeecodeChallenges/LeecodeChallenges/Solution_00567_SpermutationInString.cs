using System.Linq;
using System.Collections.Generic;
using System.Text;

public class Solution_00567_SpermutationInString
{
    public bool CheckInclusion(string s1, string s2)
    {

        if (s2.Length < s1.Length)
        {
            return false;
        }


        // 先创建s1字典
        var dic1 = new Dictionary<char, int>();
        var dic2 = new Dictionary<char, int>();
        foreach (var c in s1)
        {
            if (!dic1.Keys.Contains(c))
            {
                dic1.Add(c, 1);
                dic2.Add(c, 0);
            }
            else
            {
                dic1[c]++;
            }
        }

        char cc = '0';
        int isSame = 0;
        // 处理s2字符串，先取前n个，但要求n个里没有不存在s1里的
        var validLen = 0;
        for (var i = 0; i < s2.Length; i++)
        {
            var c = s2[i];
            if (!dic2.Keys.Contains(c))
            {
                foreach (var k in dic2.Keys)
                {
                    dic2[k] = 0;
                    validLen = 0;
                    cc = '0';
                }
            }
            else
            {
                dic2[c]++;
                validLen++;
                if (validLen < s1.Length)
                {
                    continue;
                }

                if (validLen > s1.Length)
                {
                    validLen--;
                    dic2[s2[i - s1.Length]]--;
                }

                // 这里理论上可以检查一下了，但可以更优化
                // 数字大了，要求下一步要删的是cc，并且加入的不是cc，否则不校验
                // 数字小了，要求下一步要删的不是cc，并且加入的必须是cc，否则不校验
                if ((isSame > 0 && c != cc && s2[i - s1.Length] == cc)
                    || (isSame < 0 && c == cc && s2[i - s1.Length] != cc)
                    || isSame == 0 || cc == '0')
                {
                    isSame = CheckSame(dic1, dic2, out cc);
                    if (isSame == 0)
                    {
                        return true;
                    }
                }



            }
        }


        return false;
    }

    private int CheckSame(Dictionary<char, int> dic1, Dictionary<char, int> dic2, out char errc)
    {
        var isSame = 0;
        errc = '0';
        foreach (var c in dic1.Keys)
        {
            if (dic1[c] != dic2[c])
            {
                errc = c;
                isSame = dic1[c]< dic2[c]?1:-1;
                break;
            }
        }
        return isSame;
    }

    //private string GetFingerPrint(string s1)
    //{
    //    var dic = new Dictionary<char, List<int>>();
    //    foreach (var c in s1)
    //    {
    //        if (!dic.Keys.Contains(c))
    //        {
    //            dic.Add(c, new List<int>());
    //        }
    //    }
    //    var sb = new StringBuilder();
    //    foreach(var k in dic.Keys)
    //    {
    //        sb.Append(k);
    //        sb.Append(dic[k].Count);
    //        sb.Append(',');
    //    }
    //    return sb.ToString();
    //}


    //public int CheckInclusion(string s1, string s2)
    //{
    //    if (s2.Length < s1.Length)
    //    {
    //        return -1;
    //    }

    //    /**
    //     * 基础算法：
    //     *  1. 将子串s1排序
    //     *  2. 在s2每个字符循环，当这个字符在s1子串中时，获取接下来n个（n=s1.Length)个字符，拿出来排序，跟#1进行对比
    //     *  
    //     *  */
    //    s1 = StringOrder(s1);

    //    for (var i2 = 0; i2 < s2.Length - s1.Length + 1; i2++)
    //    {
    //        var c2 = s2[i2];
    //        if (s1.Contains(c2))
    //        {
    //            // 接下来n个字符，拿出来排序，跟s2对比
    //            var stemp = StringOrder(s2.Substring(i2, s1.Length));
    //            if (stemp == s1)
    //            {
    //                return i2;
    //            }
    //        }
    //    }

    //    return -1;
    //}


    //private string StringOrder(string s1)
    //{
    //    System.Text.StringBuilder sbs1 = new System.Text.StringBuilder();
    //    return sbs1.Append(s1.OrderBy(a => a).ToArray()).ToString();
    //}

}