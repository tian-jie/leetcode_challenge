using System.Collections.Generic;
using System.Text;

//public class WordDictionary
//{
//    TreeNode headNode;
//    public WordDictionary()
//    {
//        headNode = new TreeNode('-');
//    }

//    public void AddWord(string word)
//    {
//        word = word + '\0';
//        var node = headNode;
//        //foreach(var c in word)
//        for (var i = 0; i < word.Length; i++)
//        {
//            var c = word[i];
//            TreeNode nextNode = null;
//            if (!node.childs.ToString().Contains(c))
//            {
//                nextNode = node.AddNode(c);
//            }
//            else
//            {
//                // find node:
//                foreach (var n in node.nexts)
//                {
//                    if (n.c == c)
//                    {
//                        nextNode = n;
//                        break;
//                    }
//                }
//            }

//            node = nextNode;
//        }
//    }

//    public bool Search(string word)
//    {
//        return Search(word + '\0', headNode, 0);
//    }

//    public bool Search(string word, TreeNode node, int index)
//    {
//        if (index == word.Length)
//        {
//            return true;
//        }
//        var c = word[index];

//        if (c == '.' || node.childs.ToString().Contains(c))
//        {
//            foreach (var n in node.nexts)
//            {
//                if (c == n.c || c == '.')
//                {
//                    if (!Search(word, n, index + 1))
//                    {
//                        continue;
//                    }
//                    else
//                    {
//                        return true;
//                    }
//                }
//            }

//            return false;
//        }

//        return false;
//    }
//}


//public class TreeNode
//{
//    public char c;
//    public List<TreeNode> nexts;
//    public StringBuilder childs;
//    public TreeNode(char c)
//    {
//        this.c = c;
//        nexts = new List<TreeNode>();
//        childs = new StringBuilder();
//    }
//    public TreeNode AddNode(char c)
//    {
//        childs.Append(c);
//        var node = new TreeNode(c);
//        nexts.Add(node);
//        return node;
//    }
//}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */


public class WordDictionary
{
    TreeNode headNode;
    public WordDictionary()
    {
        headNode = new TreeNode('-');
    }

    public void AddWord(string word)
    {
        word = word + '\0';
        var node = headNode;
        //foreach(var c in word)
        for (var i = 0; i < word.Length; i++)
        {
            var c = word[i];
            TreeNode nextNode = null;
            if (!node.nexts.ContainsKey(c))
            {
                nextNode = node.AddNode(c);
            }
            nextNode = node.nexts[c];

            node = nextNode;
        }
    }

    public bool Search(string word)
    {
        return Search(word + '\0', headNode, 0);
    }

    public bool Search(string word, TreeNode node, int index)
    {
        if (index == word.Length)
        {
            return true;
        }
        var c = word[index];

        if (c == '.')
        {
            foreach (var n in node.nexts)
            {
                if (!Search(word, n.Value, index + 1))
                {
                    continue;
                }
                else
                {
                    return true;
                }
            }
        }
        else if (node.nexts.ContainsKey(c))

        {
            var n = node.nexts[c];
            return Search(word, n, index + 1);
        }



        return false;
    }
}


public class TreeNode
{
    public char c;
    public Dictionary<char, TreeNode> nexts;
    public TreeNode(char c)
    {
        this.c = c;
        nexts = new Dictionary<char, TreeNode>();
    }
    public TreeNode AddNode(char c)
    {
        var node = new TreeNode(c);
        if (!nexts.ContainsKey(c))
        {
            nexts.Add(c, node);
        }
        return node;
    }
}



