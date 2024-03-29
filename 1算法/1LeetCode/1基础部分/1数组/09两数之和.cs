﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。
    你可以假设每种输入只会对应一个答案。但是，你不能重复利用这个数组中同样的元素。

    示例:
    给定 nums = [2, 7, 11, 15], target = 9
    因为 nums[0] + nums[1] = 2 + 7 = 9
    所以返回 [0, 1]
 */

namespace 基础部分
{
    class _9两数之和
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 3, 2, 4 };
            int target = 6;

            _9两数之和 c = new _9两数之和();
            var res = c.TwoSum(nums, target);
            foreach (var i in res)
                Console.Write(i + " ");
            Console.WriteLine();
        }


        public int[] TwoSum(int[] nums, int target)
        {



            int len = nums.Length;
            int[] res = new int[2];

            for (int i = 0; i < len - 1; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        res[0] = i;
                        res[1] = j;
                        return res;
                    }

                }
            }

            return res;
        }
    }
}
