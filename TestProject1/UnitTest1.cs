using Median2SortedArrays;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] nums1 = [1, 3], nums2 = [2];
            double expected = 2.0;

            Solution solution = new Solution();
            double result = solution.FindMedianSortedArrays(nums1, nums2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] nums1 = [1, 2], nums2 = [3, 4];
            double expected = 2.5;

            Solution solution = new Solution();
            double result = solution.FindMedianSortedArrays(nums1, nums2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] nums1 = [1, 2, 3, 4, 5, 6, 7, 8, 9], nums2 = [-5, -4, -3, -2, -1, 0];
            double expected = 2;

            Solution solution = new Solution();
            double result = solution.FindMedianSortedArrays(nums1, nums2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] nums1 = [1, 1, 1, 1, 5, 6, 7, 8, 9], nums2 = [-5, -4, -3, -2, -1, 0];
            double expected = 1;

            Solution solution = new Solution();
            double result = solution.FindMedianSortedArrays(nums1, nums2);
            Assert.AreEqual(expected, result);
        }

    }
}