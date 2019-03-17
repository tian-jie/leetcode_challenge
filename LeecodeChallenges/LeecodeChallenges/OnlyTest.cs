using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LeecodeChallenges
{
    public class OnlyTest
    {
        public void Test()
        {
            A a = new A();
            a.x = Convert.ToInt32("33");
        }

    }

    public class A
    {
        public int? x { get; set; }
    }
}
