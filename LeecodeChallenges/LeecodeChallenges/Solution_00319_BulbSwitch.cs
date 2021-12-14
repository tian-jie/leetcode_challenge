using System.Linq;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

public class Solution_00311_BulbSwitch
{
    public int BulbSwitch(int n)
    {
        // 先不要脸地以各个素数指定其以下的亮灯数量，然后以最大的不大于n/2的素数以下直接得出结果，以上的再算一遍各自的数字
        //先假设每1000万一个数，计算各个节点的数量
        var x = (int)Math.Sqrt(n);

        return x;
    }

    //public int BulbSwitch(int n)
    //{
    //    bool[] num = new bool[n];
    //    for (var i = 0; i < n; i++)
    //    {
    //        num[i] = true;
    //    }

    //    // 先来一个最基本的算法，挨个循环
    //    for (var i = 2; i <= n; i++)
    //    {
    //        for (var j = i - 1; j < n; j += i)
    //        {
    //            num[j] = !num[j];
    //        }
    //    }


    //    var cnt = 0;
    //    using (var sw = new StreamWriter("/Users/tianjie/workspaces/2.csv"))
    //    {
    //        for (var i = 0; i < n; i++)
    //        {
    //            if (num[i] == true)
    //            {
    //                cnt++;
    //                sw.WriteLine("{0}, {1}", cnt, i+1);
    //            }
    //            //Console.WriteLine("{0}, {1}", i + 1, cnt);
    //        }
    //        sw.Close();
    //    }
    //    return cnt;
    //}
}