using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution_00036_IsValidSudoku
{
    public bool IsValidSudoku(char[][] board)
    {
        var isSolved = false;
        for (var xxxx = 0; xxxx < 100000; xxxx++)
        {
            //// 先转成int的一维数组
            //var boardint = new char[81];

            //for (var i = 0; i < 81; i++)
            //{
            //    var m = i / 9;
            //    var n = i % 9;

            //    //if (board[m][n] != '.')
            //    {
            //        boardint[i] = board[m][n];
            //    }
            //}

            //isSolved = Filter(boardint);

            isSolved = Filter1(board);

        }
        return isSolved;
    }

    private bool Filter(char[] board)
    {
        // 然后针对每个格子，计算行、列、小方格的数字，进行排除
        for (var i = 0; i < 81; i++)
        {
            var m = i / 9;
            var n = i % 9;
            var c = board[i];
            if (c == '.')
            {
                continue;
            }

            for (var j = 0; j < 9; j++)
            {
                if (j == n)
                {
                    continue;
                }
                var xx = m * 9 + j;
                if (board[xx] == c)
                {
                    return false;
                }
            }

            for (var j = 0; j < 9; j++)
            {
                if (j == m)
                {
                    continue;
                }
                var xx = j * 9 + n;
                if (board[xx] == c)
                {
                    return false;
                }
            }

            for (var x = m - m % 3; x < m - m % 3 + 3; x++)
            {
                for (var y = n - n % 3; y < n - n % 3 + 3; y++)
                {
                    if (x == m && y == n)
                    {
                        continue;
                    }
                    var xx = x * 9 + y;
                    if (board[xx] == c)
                    {
                        return false;
                    }
                }
            }


        }

        return true;
    }
    private bool Filter1(char[][] board)
    {
        // 然后针对每个格子，计算行、列、小方格的数字，进行排除
        for (var m = 0; m < 9; m++)
            for (var n = 0; n < 9; n++)
            {

                var i = m * 9 + n;
                var c = board[m][n];
                if (c == '.')
                {
                    continue;
                }

                for (var j = 0; j < 9; j++)
                {
                    if (j == n)
                    {
                        continue;
                    }
                    var xx = m * 9 + j;
                    if (board[m][j] == c)
                    {
                        return false;
                    }
                }

                for (var j = 0; j < 9; j++)
                {
                    if (j == m)
                    {
                        continue;
                    }
                    var xx = j * 9 + n;
                    if (board[j][n] == c)
                    {
                        return false;
                    }
                }

                for (var x = m - m % 3; x < m - m % 3 + 3; x++)
                {
                    for (var y = n - n % 3; y < n - n % 3 + 3; y++)
                    {
                        if (x == m && y == n)
                        {
                            continue;
                        }
                        var xx = x * 9 + y;
                        if (board[x][y] == c)
                        {
                            return false;
                        }
                    }
                }


            }

        return true;
    }


}