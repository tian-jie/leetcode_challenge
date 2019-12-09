using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetcodeChallenges.Test
{
    public class Solution_00046_RotateTest
    {
        Solution_00046_Rotate obj = new Solution_00046_Rotate();

        [Fact]
        public void Case_01()
        {
            var arr = JsonConvert.DeserializeObject<int[][]>("[[1]]");
            obj.Rotate(arr);
            var result = JsonConvert.SerializeObject(arr);
            Assert.Equal("[[1]]", result);
        }

        [Fact]
        public void Case_02()
        {
            var arr = JsonConvert.DeserializeObject<int[][]>("[[1,2,3],[4,5,6],[7,8,9]]");
            obj.Rotate(arr);
            var result = JsonConvert.SerializeObject(arr);
            Assert.Equal("[[7,4,1],[8,5,2],[9,6,3]]", result);
        }

        [Fact]
        public void Case_03()
        {
            var arr = JsonConvert.DeserializeObject<int[][]>("[[1,2],[3,4]]");
            obj.Rotate(arr);
            var result = JsonConvert.SerializeObject(arr);
            Assert.Equal("[[3,1],[4,2]]", result);
        }

        [Fact]
        public void Case_04()
        {
            var arr = JsonConvert.DeserializeObject<int[][]>("[[5, 1, 9, 11],[2, 4, 8, 10],[13, 3, 6, 7],[15, 14, 12, 16]]");
            obj.Rotate(arr);
            var result = JsonConvert.SerializeObject(arr);
            Assert.Equal("[[15,13,2,5],[14,3,4,1],[12,6,8,9],[16,7,10,11]]", result);
        }

        [Fact]
        public void Case_05()
        {
            var arr = JsonConvert.DeserializeObject<int[][]>("[[1,2,3,4],[12,13,14,5],[11,16,15,6],[10,9,8,7]]");
            obj.Rotate(arr);
            var result = JsonConvert.SerializeObject(arr);
            Assert.Equal("[[10,11,12,1],[9,16,13,2],[8,15,14,3],[7,6,5,4]]", result);
        }


    }
}