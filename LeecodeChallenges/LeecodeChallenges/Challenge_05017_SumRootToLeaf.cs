using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LeetcodeChallenges_Challenge_05017_SumRootToLeaf
{
    public class Challenge_05017_SumRootToLeaf
    {
        long totalSum = 0;
        public int SumRootToLeaf(TreeNode root)
        {
            // 深度优先遍历
            SumLeaf(root, 0);
            return (int)(totalSum % (1e7 + 7));
        }

        private void SumLeaf(TreeNode node, int sum)
        {
            sum = (sum << 1) + node.val;

            if (node.left != null)
            {
                SumLeaf(node.left, sum);
            }
            if (node.right != null)
            {
                SumLeaf(node.right, sum);
            }
            
            if(node.left == null && node.right == null)
            {
                // 叶子啦，开始计算
                totalSum += sum;
            }
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

}