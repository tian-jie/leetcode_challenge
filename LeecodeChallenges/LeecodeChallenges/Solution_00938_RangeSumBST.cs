using System.Linq;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace Solution_00938_RangeSumBSTNS
{
    public class Solution_00938_RangeSumBST
    {
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            return SumLeafs(root, low, high);
        }


        private int SumLeafs(TreeNode node, int low, int high)
        {
            var sum = 0;
            if (node.val >= low && node.val <= high)
            {
                sum += node.val;
            }

            if (node.left != null && node.val > low)
            {
                sum += SumLeafs(node.left, low, high);
            }
            if (node.right != null && node.val < high)
            {
                sum += SumLeafs(node.right, low, high);
            }
            return sum;
        }
    }


    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

}