using System;
using System.Collections.Generic;

namespace LeetcodeChallenges
{
    public class Solution_00016_ThreeSumClosest
    {
        public int ThreeSumClosest0(int[] nums, int target)
        {
            var result = new List<IList<int>>();

            // 要先排序啊先排序
            var numsList = new List<int>(nums);
            numsList.Sort();

            var newNumsList = new List<int>() { numsList[0] };
            // 如果有相同的数据，排除掉一个数据最多剩下2个
            var repeatNo = 0;
            var last = numsList[0];
            for (var i = 1; i < numsList.Count; i++)
            {
                var n = numsList[i];
                if (n == last)
                {
                    repeatNo++;
                    if (repeatNo > 2)
                    {
                        continue;
                    }
                }
                else
                {
                    repeatNo = 0;
                }

                newNumsList.Add(n);

                last = n;
            }

            nums = newNumsList.ToArray();
            var length = nums.Length;
            var lasti = nums[0] - 1;

            // 前3个先给一个预设最小值
            var closet = nums[0] + nums[1] + nums[2] - target;
            var minDistance = nums[0] + nums[1] + nums[2];

            for (var i = 0; i < length; i++)
            {
                var ni = nums[i];
                if (ni == lasti)
                {
                    continue;
                }
                var L = i + 1;
                var R = length - 1;

                while (L < R)
                {
                    var r = ni + nums[L] + nums[R] - target;
                    if (r >= minDistance && closet > 0)
                    {
                        R--;
                    }
                    else if (r <= minDistance && closet < 0)
                    {
                        L++;
                    }
                    else
                    {
                        closet = ni + nums[L] + nums[R];


                        L++;
                        R--;
                    }
                }
                lasti = nums[i];
            }

            return closet;
        }

        private int[] _nums;
        private int _target;
        private int _closet = int.MaxValue;
        private int _diff = int.MaxValue;
        private int _cnt;

        public int ThreeSumClosest1(int[] nums, int target)
        {
            _target = target;
            _cnt = nums.Length;

            // 要先排序啊先排序
            var numsList = new List<int>(nums);
            numsList.Sort();
            _nums = numsList.ToArray();

            SumIn(0, 0, 0);

            return _closet;
        }

        void SumIn(int sum, int cnt, int index)
        {
            // 这个地方的判断有问题
            var diff = Math.Abs(sum - _target);

            if (sum > _target + diff)
            {
                //_diff = Math.Abs(sum - _target);
                return;
            }

            if (cnt == 3)
            {
                if (_diff > diff)
                {
                    _closet = sum;
                    _diff = diff;
                }
                return;
            }


            for (var i = index; i < _cnt && _cnt - i + cnt >= 3; i++)
            {
                // 快速跳过接下来相同的数字，直接跳到最后一个相同的数字
                //if (i < _cnt - (3-cnt))
                //{
                //    var isContinue = true;
                //    for(var x=1; x<=(3-cnt); x++)
                //    {
                //        if(_nums[i] != _nums[i + x])
                //        {
                //            isContinue = false;
                //            break;
                //        }
                //    }
                //    if(isContinue) continue;
                //}

                var result = sum + _nums[i];

                SumIn(result, cnt + 1, i + 1);
            }
        }


        public int ThreeSumClosest(int[] nums, int target)
        {

            // 要先排序啊先排序
            Array.Sort(nums);
            var numsList1 = new List<int>();

            var sameCnt = 0;
            var lastNum = int.MinValue;
            foreach (var n in nums)
            {
                if (n == lastNum)
                {
                    sameCnt++;
                    if (sameCnt >= 4)
                    {
                        continue;
                    }
                }
                else
                {
                    sameCnt = 1;
                    lastNum = n;
                }
                numsList1.Add(n);
            }
            //numsList1.Sort();

            _nums = numsList1.ToArray();
            _closet = _nums[0] + _nums[1] + _nums[2];
            _diff = Math.Abs(_closet - target);
            _cnt = _nums.Length;

            for (var i = 0; i < _cnt - 2; i++)
            {
                if (_nums[i] > target + _diff && _nums[i] > 0) break;
                for (var j = i + 1; j < _cnt - 1; j++)
                {
                    if (_nums[i] + _nums[j] > target + _diff && _nums[j] > 0) break;
                    for (var k = j + 1; k < _cnt; k++)
                    {
                        var sum = _nums[i] + _nums[j] + _nums[k];
                        if (sum > target + _diff && _nums[k] > 0) break;

                        var diff = Math.Abs(sum - target);
                        if (diff < _diff)
                        {
                            _closet = sum;
                            _diff = diff;
                        }
                    }
                }
            }

            return _closet;
        }
    }
}