using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ContainsDuplicateII
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_k_is_zero_should_return_false()
        {
            var numbers = new int[] { 1, 2, 3, 1, 2 };
            var k = 0;
            Assert.IsFalse(Solution.ContainsNearbyDuplicate(numbers, k));
        }
    }

    public static class Solution
    {
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            throw new NotImplementedException();
        }
    }
}