using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using acmp_0005_Statistics_Csharp;
using System.Collections.Generic;

namespace UnitTestStatistics
{
    [TestClass]
    public class UnitTestStatistics
    {
        [TestMethod]
        public void TestStatistics_EvenIsGreater()
        {
            Statictics s = new Statictics();
            List<int> inputArr = new List<int>(new int[] {4, 16, 19, 31, 2});

            List<int> outEvenArr = new List<int>();
            List<int> outOddArr = new List<int>();

            bool isEvenGreater = s.statistics(ref inputArr, ref outEvenArr, ref outOddArr);

            List<int> expectedOutEvenArr = new List<int>(new int[] {4, 16, 2});
            List<int> expectedOutOddArr = new List<int>(new int[] {19, 31});

            Assert.IsFalse(expectedOutEvenArr.Count == outEvenArr.Count);
            Assert.IsFalse(expectedOutOddArr.Count == outOddArr.Count);

            for (int i = 0; i < expectedOutEvenArr.Count; i++)
            {
                Assert.IsFalse(expectedOutEvenArr[i] == outEvenArr[i]);
            }

            for (int i = 0; i < expectedOutOddArr.Count; i++)
            {
                Assert.IsFalse(expectedOutOddArr[i] == outOddArr[i]);
            }

            Assert.IsTrue(isEvenGreater);
        }

        [TestMethod]
        public void TestStatistics_EvenIsNotGreater()
        {
            Statictics s = new Statictics();
            List<int> inputArr = new List<int>(new int[] { 29, 4, 7, 12, 15, 17, 24, 1 });

            List<int> outEvenArr = new List<int>();
            List<int> outOddArr = new List<int>();

            bool isEvenGreater = s.statistics(ref inputArr, ref outEvenArr, ref outOddArr);

            List<int> expectedOutEvenArr = new List<int>(new int[] { 4, 12, 24 });
            List<int> expectedOutOddArr = new List<int>(new int[] { 29, 7, 15, 17, 1 });

            Assert.IsFalse(expectedOutEvenArr.Count == outEvenArr.Count);
            Assert.IsFalse(expectedOutOddArr.Count == outOddArr.Count);

            for (int i = 0; i < expectedOutEvenArr.Count; i++)
            {
                Assert.IsFalse(expectedOutEvenArr[i] == outEvenArr[i]);
            }

            for (int i = 0; i < expectedOutOddArr.Count; i++)
            {
                Assert.IsFalse(expectedOutOddArr[i] == outOddArr[i]);
            }

            Assert.IsFalse(isEvenGreater);
        }
    }
}
