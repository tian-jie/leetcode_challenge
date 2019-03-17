using System.Linq;
using System.Text;
using Xunit;

namespace LeecodeChallenges.Test
{
    public class Solution_00016_ThreeSumClosestTest
    {
        Solution_00016_ThreeSumClosest obj = new Solution_00016_ThreeSumClosest();
        [Fact]
        public void case_01()
        {
            int[] num = { 0, 0, 0 };
            var result = obj.ThreeSumClosest(num, 1);

            Assert.Equal(0, result);
        }

        [Fact]
        public void case_02()
        {
            int[] num = { 1, 2, 3, 4, 0 };
            var result = obj.ThreeSumClosest(num, 1000);

            Assert.Equal(9, result);
        }

        [Fact]
        public void case_03()
        {
            int[] num = { 1, 1, 1, 1 };
            var result = obj.ThreeSumClosest(num, -19999999);

            Assert.Equal(3, result);
        }

        [Fact]
        public void case_04()
        {
            int[] num = { -1, 2, 1, -4 };
            var result = obj.ThreeSumClosest(num, 1);

            Assert.Equal(2, result);
        }
        [Fact]
        public void case_05()
        {
            int[] num = { 0, -1, 2, 1, -4 };
            var result = obj.ThreeSumClosest(num, 1);

            Assert.Equal(1, result);
        }

        [Fact]
        public void case_06()
        {
            int[] num = { -1, 2, 1, -4 };
            var result = obj.ThreeSumClosest(num, 5);

            Assert.Equal(2, result);
        }

        [Fact]
        public void case_07()
        {
            int[] num = { 1, 1, 1, 0, 1, 1, 0, 1, 0, 2 };
            var result = obj.ThreeSumClosest(num, -100);

            Assert.Equal(0, result);
        }
        [Fact]
        public void case_08()
        {
            int[] num = { 1,2,5,10,11};
            var result = obj.ThreeSumClosest(num, 12);

            Assert.Equal(13, result);
        }

        [Fact]
        public void case_995()
        {
            int[] num = { 6, -18, -20, -7, -15, 9, 18, 10, 1, -20, -17, -19, -3, -5, -19, 10, 6, -11, 1, -17, -15, 6, 17, -18, -3, 16, 19, -20, -3, -17, -15, -3, 12, 1, -9, 4, 1, 12, -2, 14, 4, -4, 19, -20, 6, 0, -19, 18, 14, 1, -15, -5, 14, 12, -4, 0, -10, 6, 6, -6, 20, -8, -6, 5, 0, 3, 10, 7, -2, 17, 20, 12, 19, -13, -1, 10, -1, 14, 0, 7, -3, 10, 14, 14, 11, 0, -4, -15, -8, 3, 2, -5, 9, 10, 16, -4, -3, -9, -8, -14, 10, 6, 2, -12, -7, -16, -6, 10 };
            var result = obj.ThreeSumClosest(num, -52);

            Assert.Equal(-52, result);
        }

        [Fact]
        public void case_996()
        {
            int[] num = { 15, 7, 52, 63, -43, -59, -54, -34, 2, -63, 27, 20, -71, -40, 62, -33, -19, 85, 12, -52, -13, 29, 48, -48, 82, 69, -27, -84, 95, 48, 78, -66, 54, -34, -29, -89, -63, -42, 12, 95, 67, -70, 85, 58, -76, -68, -19, -16, -15, -5, -3, -18, 9, -43, 16, -49, -67, 43, 3, -97, 39, -99, -29, 97, -31, 20, 95, -67, -31, 93, -13, 97, 25, -97, -73, -74, -22, -35, -52, -27, 66, -50, 18, 31, 26, -63, 97, -85, 65, -15, 40, 81, 60, 46, 13, -28, 87, -72, -95, 19, 58, 92, -8, -75, 22, 43, 45, -91, -5, 50, -41, 29, -88, -98, 36, -34, 66, -14, -67, 79, 12, -51, -78, 95, 9, 67, -54, -44, -96, 90, -92, -59, -15, -29, 28, 38, 62, -30, 63, -88, -1, 89, -48, 63, -74, -42, 9, 20, -39, 39, 22, 40, -99, -55, -61, 99, 28, 16, -19, -87, -31, -90, -61, -97, -24, -100, 45, -63, 76 };
            var result = obj.ThreeSumClosest(num, 137);

            Assert.Equal(137, result);
        }

        [Fact]
        public void case_997()
        {
            int[] num = { 8, 72, 12, 8, -82, 16, 27, 85, -16, 37, 82, 99, -75, 77, 92, 59, 10, -39, 85, -66, 35, -75, -42, -17, -26, -86, -68, -33, 79, -71, 93, 35, -93, 92, 53, 75, 72, -16, 41, -4, 20, 6, -5, 63, -14, -86, 97, -77, -27, -99, 58, -35, 55, 43, -17, 95, -3, -59, -5, 25, -88, -59, -64, -39, -36, 38, -42, 56, -56, 24, -12, 78, -85, -90, -90, 8, 58, -27, -69, -79, -35, 64, 21, -6, 51, -17, -15, 78, 97, 89, -14, -96, -30, 94, -21, 69, 21, -67, 51, 19, -36, 65, 97, 85, 43, 78, -70, 96, 62, -64, -93, 6, -63, 22, -44, -16, -10, -99, -56, 32, 55, -89, -48, 90, -4, -94, -17, 43, 71, 61, -38, 95, 90, 88, 41, -10, 95, -53, 48, 18, -28, 82, 43, -59, -21, 28, -62, 74, 48, -63, 46, 17, -38, -14, 46, 71, -10, -52, 8, 33, 29, -55, -16, -75, 55, -85, -43, 39, 39, 0, -52, 24, 90, -49, -87, 94, -76, -5, -42, -21 };
            var result = obj.ThreeSumClosest(num, -101);

            Assert.Equal(-101, result);
        }

        [Fact]
        public void case_998()
        {
            int[] num = { -16, -2, 17, -16, 3, -7, -13, 20, -4, 12, 5, 13, -7, 0, 5, 4, -17, -16, 9, 1, 8, -6, 0, -8, 16, 10, -6, 9, -4, 12, 16, 5, 19, 2, -9, -17, -8, -17, 7, -10, 2, 20, -18, -20, -14, -6, 6, 17, -10, -8, 18, -15, 7, -9, 13, 13, -13, 3, 18, 10, 12, 16, -6, -19, -6, -13, 8, -5, 16, 5, 8, -3, -9, -9, -5, 14, 14, -13, -18, 13, 15, -3, 9, 14, 18, -14, -14, 1, 20, -4, -6, 0, 3, 15, 20, 20, 9, 13, -8, -1, -2, 6 };
            var result = obj.ThreeSumClosest(num, -58);

            Assert.Equal(-57, result);
        }
        [Fact]
        public void case_999()
        {
            int[] num = { -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4, -1, 2, 1, -4 };
            var result = obj.ThreeSumClosest(num, 5);

            Assert.Equal(5, result);
        }

    }
}
