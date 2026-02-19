using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solution.Array
{
    internal class FindMedianSortedArrays
    {
        public double FindMedianofSortedArrays(int[] nums1, int[] nums2)
        {
            int[] meargearr = nums1.Concat(nums2).ToArray();
            System.Array.Sort(meargearr);

            return 0.0;
        }
    }
}
