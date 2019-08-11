using BinaryGap;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodilityTests
{
    [TestClass]
    public class BinaryGap
    {
        [TestMethod()]
        public void Solution_BinaryGap_for_456_is_2()
        {
            int expected = 2;
            var actual = Solution.solution(456);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution_BinaryGap_for_321_is_5()
        {
            int expected = 5;
            var actual = Solution.solution(321);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution_BinaryGap_for_1001_is_2()
        {
            int expected = 2;
            var actual = Solution.solution(1001);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution_BinaryGap_for_9_is_2()
        {
            int expected = 2;
            var actual = Solution.solution(9);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Solution_BinaryGap_for_0_is_0()
        {
            int expected = 0;
            var actual = Solution.solution(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Recursion_BinaryGap_for_456_is_2()
        {
            int expected = 2;
            var actual = Recursion.Solution(456);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Recursion_BinaryGap_for_321_is_5()
        {
            int expected = 5;
            var actual = Recursion.Solution(321);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Recursion_BinaryGap_for_1001_is_2()
        {
            int expected = 2;
            var actual = Recursion.Solution(1001);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Recursion_BinaryGap_for_9_is_2()
        {
            int expected = 2;
            var actual = Recursion.Solution(9);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Recursion_BinaryGap_for_0_is_0()
        {
            int expected = 0;
            var actual = Recursion.Solution(0);
            Assert.AreEqual(expected, actual);
        }
    }
}