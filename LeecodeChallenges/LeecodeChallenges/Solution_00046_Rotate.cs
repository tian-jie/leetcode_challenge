using System;
using System.Linq;

public class Solution_00046_Rotate
{
    public void Rotate(int[][] matrix)
    {
        //var n = (int)Math.Sqrt(matrix.Length);
        var n = matrix.Length;

        // 从外层向里层循环，一共(n-1)/2层
        for (var level = n - 1; level > 0; level--)
        {
            var start = n - level - 1;
            var xs = start;
            var ys = start;
            var xe = n - xs - 1;
            var ye = n - xs - 1;

            for (var x = 0; x < xe - xs; x++)
            {
                var y = ys;

                // 上: 
                var top = matrix[ys][x + xs];
                // 右: 
                var right = matrix[ys + x][xe];
                // 下: 
                var bottom = matrix[ye][xe - x];
                // 左: 
                var left = matrix[ye - x][xs];

                // 左 --> 上
                matrix[ys][x + xs] = left;

                // 下 --> 左
                matrix[ye - x][xs] = bottom;

                // 右 --> 下
                matrix[ye][xe - x] = right;

                // 上 --> 右
                matrix[ys + x][xe] = top;

            }

        }
    }
}