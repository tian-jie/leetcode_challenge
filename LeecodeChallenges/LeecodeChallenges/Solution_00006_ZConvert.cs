using System.Collections.Generic;
using System.Text;

namespace LeecodeChallenges
{
    public class Solution_00006_ZConvert
    {

        public string Convert(string s, int numRows)
        {
            var len = s.Length;
            if (len < numRows)
            {
                return s;
            }

            StringBuilder sb = new StringBuilder();
            var magic = numRows + numRows - 2;
            magic = magic == 0 ? 1 : magic;
            // 计算列组数
            var groupNum = len / magic;

            groupNum += (len % magic == 0 ? 0 : 1);


            var temp = 0;
            for (var line = 0; line < numRows; line++)
            {
                for (var i = 0; i < groupNum; i++)
                {
                    if (line != 0 && line != numRows - 1)
                    {
                        if (i == 0)
                        {
                            temp = line;
                            sb.Append(s[temp]);
                            Append(sb, s, len, i * magic - line + magic);
                            continue;
                        }

                        Append(sb, s, len, i * magic + line);
                        Append(sb, s, len, i * magic - line + magic);
                    }
                    else if (line == 0)
                    {
                        Append(sb, s, len, i * magic);
                    }
                    else if (line == numRows - 1)
                    {
                        Append(sb, s, len, i * magic + line);
                    }
                }
            }


            return sb.ToString();
        }

        void Append(StringBuilder sb, string s, int len, int index)
        {
            if (index < len)
            {
                sb.Append(s[index]);
            }
        }



    }
}
