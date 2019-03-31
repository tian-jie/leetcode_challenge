using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LeetcodeChallenges
{
    public class Solution_00012_IntToRoman
    {
        public string IntToRoman(int num)
        {
            var n = num;
            var level = 0;
            var s = "";

            while (n > 0)
            {
                var n1 = n % 10;
                n = n / 10;


                var r = ConvertByLevel(level++, n1);
                s = r + s;
            }

            return s;
        }

        static string LevelMap = "IVXLCDM";
        private string ConvertByLevel(int level, int num)
        {
            if (num == 0)
            {
                return "";
            }
            var c1 = LevelMap[level * 2];
            var c2 = '0';
            var c3 = '0';
            if (level < 3)
            {
                c2 = LevelMap[level * 2 + 1];
                c3 = LevelMap[level * 2 + 2];
            }
            string s = "";

            switch (num)
            {
                case 1:
                    s += c1;
                    break;
                case 2:
                    s += c1;
                    s += c1;
                    break;
                case 3:
                    s += c1;
                    s += c1;
                    s += c1;
                    break;
                case 4:
                    s += c1;
                    s += c2;
                    //sb.Append(c1);
                    //sb.Append(c2);

                    break;
                case 5:
                    s += c2;
                    //sb.Append(c2);
                    break;
                case 6:
                case 7:
                case 8:
                    s += c2;
                    //sb.Append(c2);
                    for (var i = 0; i < num - 5; i++)
                    {
                        s += c1;
                        //sb.Append(c1);
                    }
                    break;
                case 9:
                    s += c1;
                    s += c3;
                    //sb.Append(c1);
                    //sb.Append(c3);
                    break;
            }

            return s;

        }
    }
}
