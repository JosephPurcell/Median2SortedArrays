using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Median2SortedArrays
{
    public class Solution
    {

        // Leetcode stats
        // Runtime 80ms - Beats 96.54%
        // Memory 54.71MB - Beats 55.31%

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double medianValue = 0;

            int[] allNums = new int[nums1.Length + nums2.Length];

            nums1.CopyTo(allNums, 0);
            nums2.CopyTo(allNums, nums1.Length);
            Array.Sort<int>(allNums);

            int medianIndex1 = (allNums.Length) / 2;
            int medianIndex2 = (allNums.Length - 1) / 2;
            medianValue = ((double)allNums[medianIndex1] + (double)allNums[medianIndex2]) / 2;

            return medianValue;
        }
    }
}
