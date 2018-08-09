using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace DemoLottery
{
    [TestClass]
    public class DemoTest
    {
        [TestMethod]
        public void ReturnAnEmptyList()
        { 
            var lotteryNumbers = new List<int>();

            var lottery = new DemoLottery();

            Assert.IsTrue(lottery.GetLotteryNumbers().Count==0);
        }
        [TestMethod]
        public void ReturnAListOfNumbers()
        {
            var lotteryNumbers = new List<int>() { 1,5,7,8};
            
            var lottery = new DemoLottery();
         
            var expected = new List<int> { 1, 5, 7, 8 };
            var actual = lottery.GetLotteryNumbers(1);
            actual = lottery.GetLotteryNumbers(5);
            actual = lottery.GetLotteryNumbers(7);
            actual = lottery.GetLotteryNumbers(8);
            Assert.IsTrue((expected.Count == actual.Count) && !expected.Except(actual).Any());
        }
        [TestMethod]
        public void ReturnASortedList()
        {
            var lottery = new DemoLottery();
            var expected = new List<int> { 1,2,3};
            var actual = lottery.GetLotteryNumbers(2);
            actual = lottery.GetLotteryNumbers(1);
            actual = lottery.GetLotteryNumbers(3);
            CollectionAssert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void MultipleDrawnNumbers()
        {
            var lotteryNumbers = new List<int>();
            var lottery = new DemoLottery();
            
            var expectedEmpty = new List<int> ();
            var actual = lottery.GetLotteryNumbers();
            CollectionAssert.AreEqual(expectedEmpty, actual);
            
            var expected5 =new List<int>() { 5};
            actual = lottery.GetLotteryNumbers(5);
            CollectionAssert.AreEqual(expected5, actual);
            
            var expected15= new List<int>() { 1, 5 };
            actual = lottery.GetLotteryNumbers(1);
            CollectionAssert.AreEqual(expected15, actual);
            
            var expected1533 = new List<int>() { 1, 5, 33 };
            actual = lottery.GetLotteryNumbers(33);
            CollectionAssert.AreEqual(expected1533, actual);
        }
    }
}
