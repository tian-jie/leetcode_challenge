using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetcodeChallenges.Test
{
    public class Solution_00021_MergeTwoListsTest
    {
        Solution_00021_MergeTwoLists obj = new Solution_00021_MergeTwoLists();

        [Fact]
        public void Case1()
        {
            var n1 = ConvertListToListNode(new List<int>() { 1, 2, 4 });
            var n2 = ConvertListToListNode(new List<int>() { 1, 3, 4 });

            var result = obj.MergeTwoLists(n1, n2);

            Assert.Equal("112344", ConvertNodeListToString(result));
        }

        [Fact]
        public void Case2()
        {
            var n1 = ConvertListToListNode(new List<int>() { });
            var n2 = ConvertListToListNode(new List<int>() { 1, 3, 4 });

            var result = obj.MergeTwoLists(n1, n2);

            Assert.Equal("134", ConvertNodeListToString(result));
        }

        [Fact]
        public void Case3()
        {
            var n1 = ConvertListToListNode(new List<int>() { });
            var n2 = ConvertListToListNode(new List<int>() { });

            var result = obj.MergeTwoLists(n1, n2);

            Assert.Equal("", ConvertNodeListToString(result));
        }

        [Fact]
        public void Case4()
        {
            var n1 = ConvertListToListNode(new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            var n2 = ConvertListToListNode(new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });

            var result = obj.MergeTwoLists(n1, n2);

            Assert.Equal("111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111", ConvertNodeListToString(result));
        }

        [Fact]
        public void Case5()
        {
            var n1 = ConvertListToListNode(new List<int>() { 2 });
            var n2 = ConvertListToListNode(new List<int>() { 1 });

            var result = obj.MergeTwoLists(n1, n2);

            Assert.Equal("12", ConvertNodeListToString(result));
        }

        private Solution_00021_MergeTwoLists.ListNode ConvertListToListNode(List<int> nums)
        {
            var result = new Solution_00021_MergeTwoLists.ListNode(0);
            var r = result;
            for (var i = 0; i < nums.Count; i++)
            {
                r.next = new Solution_00021_MergeTwoLists.ListNode(nums[i]);
                r = r.next;
            }

            return result.next;
        }

        private string ConvertNodeListToString(Solution_00021_MergeTwoLists.ListNode node)
        {
            var sb = new StringBuilder();
            while (node != null)
            {
                sb.Append(node.val.ToString());
                node = node.next;
            }
            return sb.ToString();
        }
    }
}