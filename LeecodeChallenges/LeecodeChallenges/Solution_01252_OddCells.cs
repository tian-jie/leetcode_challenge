using System.Linq;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace Solution_01252_OddCells
{
    public class Solution
    {
        public int OddCells(int m, int n, int[][] indices)
        {
            var arr = new int[n * m];

            foreach (var indice in indices)
            {
                // 这一行上的所有内容
                for (var i = indice[0] * n; i < indice[0] * n + n; i++)
                {
                    arr[i]++;
                }

                // 这一列的算法
                for (var i = 0; i < m; i++)
                {
                    arr[indice[1] + n * i]++;
                }
            }
            return arr.Count(a => a % 2 == 1);
        }
    }
}