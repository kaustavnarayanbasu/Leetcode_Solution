using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solution
{
    internal class TwoSum
    {
        public static int[] FindTwoSum(int[] nums, int target)
        {

            int sum = 0;

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                for (int j = i + 1; j <= nums.Length - 1; j++)
                {
                    sum = nums[i] + nums[j];
                    if (sum == target)
                    {
                        return new int[] { i, j };

                    }
                    
                }
            }
            return Array.Empty<int>();
        }
    }
}
