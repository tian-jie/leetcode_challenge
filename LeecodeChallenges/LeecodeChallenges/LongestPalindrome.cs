using System.Collections.Generic;
using System.Linq;

public class Solution00005
{
    Dictionary<char, List<int>> _dic = new Dictionary<char, List<int>>();
    string _s = "";
    string _maxString = "";

    public string LongestPalindrome(string s)
    {
        // 先给每个字母做字典
        _s = s;
        var len = s.Length;
        for (var i = 0; i < len; i++)
        {
            var c = s[i];
            if (!_dic.ContainsKey(c))
            {
                _dic[c] = new List<int>();
            }
            _dic[c].Add(i);
        }

        // 然后遍历字典里的每个字母
        // 比如字母a，是1,10, 20, 100，就先看1,100，然后看2是什么，同一个里有没有99。如果有的话继续3,98....
        // 如果1,100失败，看1,20，然后1,10，然后10,100，然后10,20,,,20,100.....
        foreach (var c in _dic.Keys)
        {
            var values = _dic[c];
            var idxEnd = values.Count - 1;

            var cnt = values.Count;
            for (var x = 0; x < cnt; x++)
            {
                for (var y = idxEnd; y >= x; y--)
                {
                    var distance = _dic[c][y] - _dic[c][x];
                    if (distance < _maxString.Length)
                    {
                        continue;
                    }

                    if (IsPalindrome(c, x, y))
                    {
                        // 如果true了，记录一下当前长度和内容
                        var strIndexS = values[x];
                        var strIndexE = values[y];
                        var str = s.Substring(strIndexS, strIndexE - strIndexS + 1);
                        if (str.Length > _maxString.Length)
                        {
                            _maxString = str;
                        }
                    }
                }
            }
        }

        return _maxString;
    }

    /// <summary>
    ///  被递归调用的函数
    /// </summary>
    /// <param name="begin"></param>
    /// <param name="end"></param>
    /// <returns></returns>
    private bool IsPalindrome(char c, int idxBegin, int idxEnd)
    {
        // 是值差1，不是距离差1
        var distance = _dic[c][idxEnd] - _dic[c][idxBegin];
        if (distance <= 1)
        {
            return true;
        }

        var result = true;
        
        var x = _dic[c][idxBegin] + 1;
        var y = _dic[c][idxEnd] - 1;
        // 如果大于0，看里面是否是回文
        while (y >= x)
        {
            if(_s[x] != _s[y])
            {
                result = false;
                break;
            }
            x++;
            y--;
        }

        return result;
    }
}