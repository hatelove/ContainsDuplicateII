using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ContainsDuplicateII
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_k_is_zero_should_return_false()
        {
            var nums = new int[] { 1, 2, 3, 1, 2 };
            var k = 0;
            Assert.IsFalse(Solution.ContainsNearbyDuplicate(nums, k));
        }

        [TestMethod]
        public void Test_nums_5_5_and_k_is_1_should_return_true()
        {
            var nums = new int[] { 5, 5 };
            var k = 1;
            Assert.IsTrue(Solution.ContainsNearbyDuplicate(nums, k));
        }

        [TestMethod]
        public void Test_nums_5_6_and_k_is_1_should_return_false()
        {
            var nums = new int[] { 5, 6 };
            var k = 1;
            Assert.IsFalse(Solution.ContainsNearbyDuplicate(nums, k));
        }

        [TestMethod]
        public void Test_nums_5_6_5_and_k_is_1_should_return_false()
        {
            var nums = new int[] { 5, 6, 5 };
            var k = 1;
            Assert.IsFalse(Solution.ContainsNearbyDuplicate(nums, k));
        }

        [TestMethod]
        public void Test_nums_5_6_5_and_k_is_2_should_return_true()
        {
            var nums = new int[] { 5, 6, 5 };
            var k = 2;
            Assert.IsTrue(Solution.ContainsNearbyDuplicate(nums, k));
        }
    }

    public static class Solution
    {
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if (k == 0) return false;

            var windowSize = k + 1;
            for (int i = 0; i < nums.Length; i++)
            {
                var windowNums = nums.Skip(i).Take(windowSize);
                var set = new HashSet<int>();
                foreach (var windowNum in windowNums)
                {
                    if (!set.Add(windowNum)) return true;
                }
            }

            return false;
        }
    }
}