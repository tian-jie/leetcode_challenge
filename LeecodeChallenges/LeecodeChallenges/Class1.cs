using System;
using System.Collections.Generic;
using System.Diagnostics;

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
            var numsList = new List<int>(nums);
            numsList.Sort();
            nums = numsList.ToArray();

            // 要先排序啊先排序
            var length = nums.Length;

            for (var i = 0; i < length; i++)
            {
                //Debug.WriteLine(new DateTime().Ticks);
                if (nums[i] > 0)
                {
                    break;
                }
                var temp1 = nums[i];
                for (var j = i + 1; j < length; j++)
                {
                    var temp2 = temp1 + nums[j];
                    if (temp2 > 0)
                    {
                        break;
                    }
                    // 最后一个数折半查找？？？
                    var k = j + 1;
                    var indexL = k;
                    var indexR = length - 1;
                    var index = indexL + (indexR - indexL + 1) / 2;
                    while (indexR >= indexL && index >= indexL && index <= indexR)
                    {
                        //Debug.WriteLine("{0}:{3}, {1}:{4}, {2}:{5}", i, j, index, nums[i], nums[j], nums[index]);
                        if (temp2 + nums[index] > 0)
                        {
                            indexR = index-1 ;
                        }
                        else if (temp2 + nums[index] < 0)
                        {
                            indexL = index+1;
                        }
                        else if (temp2 + nums[index] == 0)
                        {
                            var isEqual = false;
                            foreach (var r in result)
                            {
                                if (nums[i] == r[0] && nums[j] == r[1] && nums[index] == r[2])
                                {
                                    isEqual = true;
                                    break;
                                }
                            }
                            if (!isEqual)
                            {
                                result.Add(new List<int>()
                                    {
                                        nums[i], nums[j], nums[index]
                                    });
                            }
                            break;
                        }

                        index = (indexR + indexL) / 2;
                    }
                    if (index >= indexL && index <= indexR && temp2 + nums[index] == 0)
                    {
                        var isEqual = false;
                        foreach (var r in result)
                        {
                            if (nums[i] == r[0] && nums[j] == r[1] && nums[index] == r[2])
                            {
                                isEqual = true;
                                break;
                            }
                        }
                        if (!isEqual)
                        {
                            result.Add(new List<int>()
                            {
                                nums[i], nums[j], nums[index]
                            });
                        }
                    }
                }

            }

            return result;
        }
    }
}
