using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ClassLottery
{
    [TestClass]
    public class ClassLotteryTest
    {
        [TestMethod]
        public void ReturnAnEmptyList()
        {
            var lotteryNumbers = new List<int>();

            var lottery = new ClassLottery(lotteryNumbers);

            Assert.IsTrue(lottery.SortLotteryNumbers().Count == 0);
        }
        [TestMethod]
        public void ReturnAListOfNumbers()
        {
            var lotteryNumbers = new List<int>() { 1, 5, 7, 8 };

            var lottery = new ClassLottery(lotteryNumbers);
            var expected = new List<int> { 1, 5, 7, 8 };
            var actual = lottery.SortLotteryNumbers();
            Assert.IsTrue((expected.Count == actual.Count) && !expected.Except(actual).Any());
        }
        [TestMethod]
        public void ReturnASortedList()
        {
            var lotteryNumbers = new List<int>() { 1, 5, 3, 7, 2 };

            var lottery = new ClassLottery(lotteryNumbers);
            var expected = new List<int> { 1, 2, 3, 5, 7 };
            var actual = lottery.SortLotteryNumbers();
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MultipleDrawnNumbers()
        {
            var lotteryNumbers = new List<int>();
            var lottery = new ClassLottery();

            var expectedEmpty = new List<int>();
            var actual = lottery.SortLotteryNumbers();
            CollectionAssert.AreEqual(expectedEmpty, actual);
            lottery.DrawNumber(5);
            var expected5 = new List<int>() { 5 };
            actual = lottery.SortLotteryNumbers();
            CollectionAssert.AreEqual(expected5, actual);
            lottery.DrawNumber(1);
            var expected15 = new List<int>() { 1, 5 };
            actual = lottery.SortLotteryNumbers();
            CollectionAssert.AreEqual(expected15, actual);
            lottery.DrawNumber(33);
            var expected1533 = new List<int>() { 1, 5, 33 };
            actual = lottery.SortLotteryNumbers();
            CollectionAssert.AreEqual(expected1533, actual);
        }
    }
}
