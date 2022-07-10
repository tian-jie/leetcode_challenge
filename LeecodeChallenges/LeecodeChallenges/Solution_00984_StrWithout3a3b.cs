using System.Linq;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace Solution_00984_StrWithout3a3b
{
    public class Solution
    {
        public string StrWithout3a3b(int a, int b)
        {
            //var c = a > b ? 'a' : 'b';
            StringBuilder sb = new StringBuilder();
            if (a == 0 && b == 0)
            {
                return "";
            }
            if (a == 0 && b == 1)
            {
                return "b";
            }
            if (a == 1 && b == 0)
            {
                return "a";
            }
            if (a == 1 && b == 1)
            {
                return "ab";
            }

            // 先看头，多出超过2个的，直接拿出来2个
            if (Math.Abs(a - b) >= 2)
            {
                sb.Append(a > b ? "aa" : "bb");
                var x = a > b ? a -= 2 : b -= 2;
            }

            var diff = Math.Abs(a - b);
            // 接下来的，按照多2少1，直到相同，然后再1:1地走
            if (a > b)
            {
                for(var i=0; i<diff; i++)
                {
                    sb.Append("baa");
                }
                for(var i=0; i < b - diff; i++)
                {
                    sb.Append("ba");
                }
            }
            else if(b > a)
            {
                for (var i = 0; i < diff; i++)
                {
                    sb.Append("abb");
                }
                for (var i = 0; i < a - diff; i++)
                {
                    sb.Append("ab");
                }
            }
            else
            {
                if (sb.Length == 0 || sb[0] == 'a')
                {
                    for (var i = 0; i < a; i++)
                    {
                        sb.Append("ba");
                    }
                }
                else
                {
                    for (var i = 0; i < a; i++)
                    {
                        sb.Append("ab");
                    }
                }
            }

            return sb.ToString();
        }
    }
}