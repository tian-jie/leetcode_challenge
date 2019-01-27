using System;
using System.Collections.Generic;

namespace LeecodeChallenges
{
    public class Solution_15_3sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums.Length < 3)
            {
                return result;
            }


            // 要先排序啊先排序
            var length = nums.Length;

            for (var i = 0; i < length; i++)
            {
                for (var j = i + 1; j < length; j++)
                {
                    var temp = nums[i] + nums[j];
                    for (var k = j + 1; k < length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            var newArray = new List<int>()
                            {
                                nums[i], nums[j], nums[k]
                            };
                            newArray.Sort();

                            var isEqual = false;
                            foreach (var r in result)
                            {
                                if(newArray[0] == r[0] && newArray[1] == r[1] && newArray[2] == r[2])
                                {
                                    isEqual = true;
                                    break;
                                }
                            }
                            if (!isEqual)
                            {
                                result.Add(newArray);
                            }
                        }
                    }

                }

            }

            return result;
        }
    }
}
