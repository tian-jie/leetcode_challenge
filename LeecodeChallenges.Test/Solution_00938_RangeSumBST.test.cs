using System;
using System.Collections.Generic;
using Solution_00938_RangeSumBSTNS;
using Xunit;

namespace LeetcodeChallenges.Test
{
    public class Solution_00938_RangeSumBSTTest
    {
        Solution_00938_RangeSumBST obj = new Solution_00938_RangeSumBST();

        [Fact]
        public void Case1()
        {
            //int?[] nums = { 10, 5, 15, 3, 7, null, 18 };
            //var root = BuildTreeNodes(nums);
            var root = new TreeNode(10);
            root.left = new TreeNode(5);
            root.right = new TreeNode(15);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(7);
            root.right.right = new TreeNode(18);

            var result = obj.RangeSumBST(root, 7, 15);

            Assert.Equal(32, result);
        }

        [Fact]
        public void Case2()
        {
            //输入：root = [10,5,15,3,7,13,18,1,null,6], low = 6, high = 10
            var root = new TreeNode(10);
            root.left = new TreeNode(5);
            root.right = new TreeNode(15);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(7);
            root.left.right.left = new TreeNode(6);
            root.left.left.left = new TreeNode(1);
            root.right.left = new TreeNode(13);
            root.right.right = new TreeNode(18);

            var result = obj.RangeSumBST(root, 6, 10);

            Assert.Equal(23, result);
        }


        private TreeNode BuildTreeNodes(int?[] nums)
        {
            TreeNode root = new TreeNode(nums[0].Value);
            var index = BuildTreeNodes(root, nums, 1);

            return root;
        }

        private int BuildTreeNodes(TreeNode node, int?[] nums, int index)
        {
            if (nums.Length > index)
            {
                if (nums[index] != null)
                {
                    node.left = new TreeNode(nums[index].Value);
                }
            }
            index++;
            if (nums.Length > index)
            {
                if (nums[index] != null)
                {
                    node.right = new TreeNode(nums[index].Value);
                }
            }
            index++;

            index = BuildTreeNodes(node.left, nums, index);
            index = BuildTreeNodes(node.right, nums, index);
            return index;
        }
    }
}