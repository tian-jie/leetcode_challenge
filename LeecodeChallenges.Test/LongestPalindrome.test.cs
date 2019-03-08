//using System;
//using System.Collections.Generic;
//using Xunit;

//namespace Solution
//{
//    public class LongestPalindrome_test
//    {
//        [Fact]
//        public void Case1()
//        {
//            var nums1 = new List<int>() { 1, 2, 4 };
//            var nums2 = new List<int>() { 1, 3, 4 };

//            var n1 = ConvertListToListNode(nums1);
//            var n2 = ConvertListToListNode(nums2);

//            var obj = new Solution00013();
//            var result = obj.LongestCommonPrefix(nums.ToArray());

//            Assert.Equal("fl", result);
//        }
//        [Fact]
//        public void Case2()
//        {
//            var nums = new List<string>() { "flower", "flowar", "flawer" };

//            var obj = new Solution00014();
//            var result = obj.LongestCommonPrefix(nums.ToArray());

//            Assert.Equal("fl", result);
//        }
//        [Fact]
//        public void Case3()
//        {
//            var nums = new List<string>() {  };

//            var obj = new Solution00014();
//            var result = obj.LongestCommonPrefix(nums.ToArray());

//            Assert.Equal("", result);
//        }
//        [Fact]
//        public void Case4()
//        {
//            var nums = new List<string>() { "flower" };

//            var obj = new Solution00014();
//            var result = obj.LongestCommonPrefix(nums.ToArray());

//            Assert.Equal("flower", result);
//        }
//        [Fact]
//        public void Case5()
//        {
//            var nums = new List<string>() { "flower", "flow", "flight" };

//            var obj = new Solution00014();
//            var result = obj.LongestCommonPrefix(nums.ToArray());

//            Assert.Equal("fl", result);
//        }
//        [Fact]
//        public void Case6()
//        {
//            var nums = new List<string>() { "flower", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight" };

//            var obj = new Solution00014();
//            var result = obj.LongestCommonPrefix(nums.ToArray());

//            Assert.Equal("fl", result);
//        }

//        private Solution00021.ListNode ConvertListToListNode(List<int> nums)
//        {
//            var result = new Solution00021.ListNode(nums[0]);
//            var r = result;
//            for(var i=1; i<nums.Count; i++)
//            {
//                r.next = new Solution00021.ListNode(nums[i]);
//                r = r.next;
//            }

//            return result;
//        }
//    }
//}