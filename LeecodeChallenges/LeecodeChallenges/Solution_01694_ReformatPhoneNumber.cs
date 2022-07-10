using System.Linq;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace Solution_001694_ReformatPhoneNumberNS
{
    public class Solution_01694_ReformatPhoneNumber
    {
        public string ReformatNumber(string number)
        {
            number = number.Replace(" ", "");
            number = number.Replace("-", "");
            //var length = number.Length;
            string s2 = number;
            var i = 0;
            for (i = 3; i < s2.Length - 1; i+=3)
            {
                s2 = s2.Insert(i++, "-");
            }
            i -= 3;
            if (s2.Length - i == 4)
            {
                s2 = s2.Insert(s2.Length - 2, "-");
            }
            return s2;
        }


    }
}