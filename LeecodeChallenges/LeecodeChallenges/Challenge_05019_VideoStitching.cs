using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace LeetcodeChallenges
{
    public class Challenge_05019_VideoStitching
    {
        int _minCnt = int.MaxValue;
        int _clipsLength = 0;
        List<Clip> _clips = new List<Clip>();

        public int VideoStitching(int[][] clips, int T)
        {
            _clipsLength = clips.Length;
            Dictionary<int, List<int>> clipsDic = new Dictionary<int, List<int>>();
            // 先处理一下clips
            foreach (var clip in clips)
            {
                _clips.Add(new Clip()
                {
                    StartTime = clip[0],
                    EndTime = clip[1]
                });
            };

            _clips = _clips.OrderBy(a => a.StartTime).ToList();

            for (var i = 0; i < _clipsLength; i++)
            {
                if (_clips[i].StartTime != 0)
                {
                    break;
                }
                FindVideoClip(i, 1, T);
            }

            return _minCnt == int.MaxValue ? -1 : _minCnt;
        }

        private void FindVideoClip(int clipsIndex, int cnt, int length)
        {
            if (_clips[clipsIndex].EndTime >= length)
            {
                if (cnt < _minCnt)
                {
                    _minCnt = cnt;
                }
                return;
            }

            for (var i = clipsIndex + 1; i < _clipsLength && _clips[i].StartTime <= _clips[clipsIndex].EndTime; i++)
            {
                if(_clips[i].EndTime <= _clips[clipsIndex].EndTime)
                {
                    continue;
                }
                FindVideoClip(i, cnt + 1, length);
            }
        }

        class Clip
        {
            public int StartTime { get; set; }
            public int EndTime { get; set; }
        }
    }


}