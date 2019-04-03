using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution_00030_FindSubstring
{
    private int _wordsNums = 0;
    private string[] _words = null;
    private string _expectedWordsIntString = "";
    Dictionary<int, List<WordInfo>> _positionWordsDic = new Dictionary<int, List<WordInfo>>();

    List<int> _result = new List<int>();


    public IList<int> FindSubstring(string s, string[] words)
    {
        _wordsNums = words.Length;
        var sLen = s.Length;
        _words = words;
        StringBuilder sb = new StringBuilder();
        for (var i = 0; i < words.Length; i++)
        {
            sb.Append(i.ToString());
        }
        _expectedWordsIntString = sb.ToString();

        // 扫描整个字符串，将这个字符串每个位置的字母能组成哪个单词，都写到这个对象里，回头从这个对象里找能够拼起来的单词组合

        for (var i = 0; i < sLen; i++)
        {
            var c = s[i];
            // 以c为一个单词的结尾去查找单词
            for (var wIndex = 0; wIndex < words.Count(); wIndex++)
            {
                var w = words[wIndex];
                var index = w.Length - 1;
                var equalWord = false;
                while (index >= 0 && i - w.Length + index + 1 >= 0)
                {
                    equalWord = true;
                    if (s[i - w.Length + index + 1] != w[index])
                    {
                        equalWord = false;
                        break;
                    }
                    index--;
                }
                // 到此为止，这个单词相等，放到dic里
                if (equalWord)
                {
                    var startIndex = i - w.Length + 1;
                    if (startIndex >= 0)
                    {
                        var wordInfo = new WordInfo() { Length = w.Length, word = w, StartIndex = startIndex, WordIndex = wIndex };
                        if (!_positionWordsDic.Keys.Contains(startIndex))
                        {
                            _positionWordsDic.Add(startIndex, new List<WordInfo>());
                        }
                        _positionWordsDic[startIndex].Add(wordInfo);
                    }
                }
            }
        }

        if (_positionWordsDic.Keys.Count() == 0)
        {
            return _result;
        }

        // 根据扫描完的数据进行组合
        // 采用深度优先搜索的方式

        // 第一个int放位置
        // 第二个int放word的index
        var tmpDic = new Dictionary<int, int>();
        foreach (var key in _positionWordsDic.Keys)
        {
            foreach (var wi in _positionWordsDic[key])
            {
                tmpDic.Add(key, wi.WordIndex);
                ContainsQueue(tmpDic, key + wi.Length);
                tmpDic.Remove(key);
            }
        }


        return _result;
    }

    private void ContainsQueue(Dictionary<int, int> wordList, int nextIndex)
    {
        // 先添加下一个
        if (!_positionWordsDic.Keys.Contains(nextIndex) && wordList.Count < _wordsNums)
        {
            return;
        }

        if (wordList.Count < _wordsNums)
        {
            foreach (var wi in _positionWordsDic[nextIndex])
            {
                wordList.Add(nextIndex, wi.WordIndex);
                ContainsQueue(wordList, nextIndex + wi.Length);
                wordList.Remove(nextIndex);
            }
        }
        else if (IntListToString(wordList.Values.OrderBy(a => a).ToList()) == _expectedWordsIntString)
        {
            var result = wordList.Keys.Min();
            // 还要判断这个结果以前出现过没
            var duplicated = false;
            foreach (var r in _result)
            {
                if (r == result)
                {
                    duplicated = true;
                    break;
                }

            }
            // 如果相同了，就是一个结果啦
            if (!duplicated)
            {
                _result.Add(result);
            }
        }
        return;
    }

    private static string IntListToString(List<int> l)
    {
        var sb = new StringBuilder();
        foreach (var i in l)
        {
            sb.Append(i.ToString());
        }
        return sb.ToString();
    }
    class WordInfo
    {
        public int Length;
        public string word;
        public int StartIndex;
        public int WordIndex;
    }


}