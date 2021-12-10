using System.Collections.Generic;

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
        for(var i=0; i<word.Length; i++)
        {
            var c = word[i];
            var isContains = false;
            TreeNode nextNode = null;
            //foreach (var n in node.nexts)
            for(var j=0; j<node.nexts.Count; j++)
            {
                var n = node.nexts[j];
                if(n.c == c)
                {
                    isContains = true;
                    nextNode = n;
                    break;
                }
            }
            if (!isContains)
            {
                nextNode = new TreeNode(c);
                node.nexts.Add(nextNode);
            }
            node = nextNode;
        }
    }

    public bool Search(string word)
    { 
        return Search(word+'\0', headNode, 0);
    }

    public bool Search(string word, TreeNode node, int index)
    {
        if(index == word.Length)
        {
            return true;
        }
        var c = word[index];

        var isContains = false;
        foreach (var n in node.nexts)
        {
            if (c == n.c || c == '.')
            {
                if (!Search(word, n, index + 1))
                {
                    continue;
                }
                else
                {
                    isContains = true;
                    break;
                }
            }
        }
        if (!isContains)
        {
            return false;
        }

        return true;
    }
}


public class TreeNode
{
    public char c;
    public List<TreeNode> nexts;

    public TreeNode(char c)
    {
        this.c = c;
        nexts = new List<TreeNode>();
    }
    //public override string ToString()
    //{
    //    return c.ToString();
    //}

    //public override int GetHashCode()
    //{
    //    return c.GetHashCode();
    //}
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
