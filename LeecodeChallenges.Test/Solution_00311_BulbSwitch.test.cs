using System;
using System.Collections.Generic;
using Xunit;

namespace LeetcodeChallenges.Test
{
    public class Solution_00311_BulbSwitchTest
    {
        Solution_00311_BulbSwitch obj = new Solution_00311_BulbSwitch();

        [Fact]
        public void Case1()
        {
            var result = obj.BulbSwitch(1);

            Assert.Equal(1, result);
        }

        [Fact]
        public void Case2()
        {
            var result = obj.BulbSwitch(2);

            Assert.Equal(1, result);
        }
        [Fact]
        public void Case0()
        {
            var result = obj.BulbSwitch(0);

            Assert.Equal(0, result);
        }
        [Fact]
        public void Case100()
        {
            var result = obj.BulbSwitch(100);

            Assert.Equal(10, result);
        }

        [Fact]
        public void Case1000()
        {
            var result = obj.BulbSwitch(1000);

            Assert.Equal(31, result);
        }

        [Fact]
        public void Case10000()
        {
            var result = obj.BulbSwitch(10000);

            Assert.Equal(100, result);
        }

        [Fact]
        public void Case100000()
        {
            var result = obj.BulbSwitch(100000);

            Assert.Equal(316, result);
        }

        [Fact]
        public void Case1000000()
        {
            var result = obj.BulbSwitch(1000000);

            Assert.Equal(1000, result);
        }

        [Fact]
        public void Case10000000()
        {
            var result = obj.BulbSwitch(10000000);

            Assert.Equal(3162, result);
        }

        [Fact]
        public void Case20000000()
        {
            var result = obj.BulbSwitch(20000000);

            Assert.Equal(5477, result);
        }

        [Fact]
        public void Case30000000()
        {
            var result = obj.BulbSwitch(30000000);

            Assert.Equal(6324, result);
        }

        [Fact]
        public void Case40000000()
        {
            var result = obj.BulbSwitch(40000000);

            Assert.Equal(6324, result);
        }

        [Fact]
        public void Case50000000()
        {
            var result = obj.BulbSwitch(50000000);

            Assert.Equal(6324, result);
        }

        [Fact]
        public void Case60000000()
        {
            var result = obj.BulbSwitch(60000000);

            Assert.Equal(6324, result);
        }

        [Fact]
        public void Case70000000()
        {
            var result = obj.BulbSwitch(70000000);

            Assert.Equal(6324, result);
        }

        [Fact]
        public void Case80000000()
        {
            var result = obj.BulbSwitch(80000000);

            Assert.Equal(6324, result);
        }

        [Fact]
        public void Case90000000()
        {
            var result = obj.BulbSwitch(90000000);

            Assert.Equal(6324, result);
        }

        [Fact]
        public void Case100000000()
        {
            var result = obj.BulbSwitch(100000000);

            Assert.Equal(10000, result);
        }

        [Fact]
        public void Case999()
        {
            var result = obj.BulbSwitch(1000000000);

            Assert.Equal(31622, result);
        }



    }
}