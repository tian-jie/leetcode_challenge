using System.Linq;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace Solution_00676_MagicDictionary
{
    public class MagicDictionary
    {
        Dictionary<char, object> _rootDictionary = new Dictionary<char, object>();
        public MagicDictionary()
        {

        }

        public void BuildDict(string[] dictionary)
        {
            foreach (var s in dictionary)
            {
                var currentDictionary = _rootDictionary;
                foreach (var c in s)
                {
                    Dictionary<char, object> nextDictionary = null;
                    if (!currentDictionary.ContainsKey(c))
                    {
                        nextDictionary = new Dictionary<char, object>();
                        currentDictionary.Add(c, nextDictionary);
                        currentDictionary = nextDictionary;
                    }
                    else
                    {
                        currentDictionary = (Dictionary<char, object>)currentDictionary[c];
                    }
                }
                currentDictionary.Add('\0', null);
            }
        }

        public bool Search(string searchWord)
        {
            return SearchPrivate(searchWord, 0, _rootDictionary, false);
        }

        private bool SearchPrivate(string searchWord, int level, Dictionary<char, object> currentDictionary, bool hasDifferent)
        {
            // 判断hasDifferent=true并且到终点了
            if (currentDictionary == null)
            {
                return false;
            }
            if (level == searchWord.Length)
            {
                if (hasDifferent && currentDictionary != null && currentDictionary.ContainsKey('\0'))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


            // 没有字母被替换过的话，广度循环
            foreach (var key in currentDictionary.Keys)
            {
                if (!hasDifferent)
                {
                    var nextDictionary = (Dictionary<char, object>)currentDictionary[key];
                    var hasResult = SearchPrivate(searchWord, level + 1, nextDictionary, (!(key == searchWord[level])) || hasDifferent);

                    if (hasResult)
                    {
                        return true;
                    }
                }
                else
                {
                    // 有过被替换的字母，则不循环了，直接深度优先
                    if (key == searchWord[level])
                    {
                        return SearchPrivate(searchWord, level + 1, (Dictionary<char, object>)currentDictionary[key], true);
                    }
                }
            }
            return false;
        }
    }
}