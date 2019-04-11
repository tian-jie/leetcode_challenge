using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LeetcodeChallenges
{
    public class Challenge_05016_RemoveOuterParentheses
    {
        public string RemoveOuterParentheses(string S)
        {
            var parenthesesCnt = 0;
            List<string> pareList = new List<string>();

            var pare = new StringBuilder();

            foreach (var c in S)
            {
                pare.Append(c);
                if (c == '(')
                {
                    parenthesesCnt++;
                }else if(c == ')')
                {
                    parenthesesCnt--;
                }

                if (parenthesesCnt == 0 )
                {
                    pareList.Add(pare.ToString());
                    pare.Clear();
                }
                
            }

            // 循环完成后将每个list里的最外层拔掉
            List<string> pareList1 = new List<string>();

            foreach (var l in pareList)
            {
                if (l.Length > 2)
                {
                    pareList1.Add(l.Substring(1, l.Length - 2));
                }
            }

            pare.Clear();
            foreach (var l in pareList1)
            {
                pare.Append(l);
            }

            return pare.ToString();
        }


    }
}
