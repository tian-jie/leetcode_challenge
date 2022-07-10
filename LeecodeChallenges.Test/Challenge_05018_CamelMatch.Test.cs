using System;
using System.Collections.Generic;
using LeetcodeChallenges_Challenge_05017_SumRootToLeaf;
using Xunit;

namespace LeetcodeChallenges.Test
{
    public class Challenge_05017_SumRootToLeafTest
    {
        Challenge_05017_SumRootToLeaf obj = new Challenge_05017_SumRootToLeaf();
        [Fact]
        public void case_01()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(0);
            root.right = new TreeNode(1);
            var node = root.left;
            node.left = new TreeNode(0);
            node.right = new TreeNode(1);
            node = root.right;
            node.left = new TreeNode(0);
            node.right = new TreeNode(1);


            var result = obj.SumRootToLeaf(root);

            Assert.Equal(22, result);
        }



    }
}
