using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution_00030_FindSubstring
{
    private List<string> _wordsStrs =new List<string>();
    private string[] _tempWords = null;
    private int _wordCnt = 0;
    private string _firstChs = "";

    public IList<int> FindSubstring(string s, string[] words)
    {
        _tempWords = (string[])words.Clone();
        _wordCnt = words.Length;

        var firstChsSB = new StringBuilder();
        foreach(var word in words)
        {
            firstChsSB.Append(word[0]);
        }

        _firstChs = firstChsSB.ToString();

        // 先组合string的所有可能
        ExhaustionWords(0);

        // 开始循环各个字符
        var result = new List<int>();
        var sIndex = 0;

        for(sIndex=0; sIndex<s.Length; sIndex++)
        {
            var c = s[sIndex];
            if (!_firstChs.Contains(c))
            {
                continue;
            }
            foreach (var wordsStr in _wordsStrs)
            {
                var isSame = true;
                if (wordsStr[0] != c)
                {
                    // 先判断第一个字符，如果相同，则看接下来的字符是否相同，如果都相同，就存一个
                    continue;
                }
                var wordStrIndex = 0;
                for (wordStrIndex = 1; wordStrIndex< wordsStr.Length; wordStrIndex++)
                {
                    if (sIndex + wordStrIndex>=s.Length || wordsStr[wordStrIndex]!=s[sIndex+ wordStrIndex])
                    {
                        isSame = false;
                        break;
                    }
                }
                if (isSame)
                {
                    result.Add(sIndex);
                    break;
                }
            }
        }


        return result;
    }

    private void ExhaustionWords(int deepth)
    {
        if (deepth == _wordCnt)
        {
            //var s = new StringBuilder();
            //foreach(var tw in _tempWords)
            //{
            //    s.Append(tw);
            //}

            //_wordsStrs.Add(s.ToString());
        }
        else
        {
            for (int i = deepth; i < _wordCnt; i++)
            {
                Swap(i, deepth);
                ExhaustionWords(deepth + 1);
                Swap(i, deepth);
            }
        }
    }

    private void Swap(int x, int y)
    {
        var ts = _tempWords[x];

        _tempWords[x] = _tempWords[y];
        _tempWords[y] = ts;
    }
}