using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryGap.UnitTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [DataRow(0)]
        public void CheckIndexValurEqualsZero(int integer)
        {
            BinaryGapCode.BinaryGap binaryGap = new BinaryGapCode.BinaryGap(integer);

            for (int i = 0; i < binaryGap.BinaryContent.Length; i++)
            {
                Assert.IsTrue(binaryGap.IsIndexValueZero(i));
            }
        }

        [TestMethod]
        [DataRow(68, 3)]
        [DataRow(516, 6)]
        public void CountCharacteresBetweenTwoIndexes(int integer, int total)
        {

            BinaryGapCode.BinaryGap binaryGap = new BinaryGapCode.BinaryGap(integer);

            int index = 0;
            int counter = binaryGap.ReturnNumberOfCharacteres(ref index);

            Assert.AreEqual(total, counter);
        }

        [TestMethod]
        //[DataRow(9, 2)]
        [DataRow(529, 4)]
        public void GetLongestBinaryLength(int integer, int gap)
        {
            BinaryGapCode.BinaryGap binaryGap = new BinaryGapCode.BinaryGap(integer);
            int longestGap = binaryGap.GetLongestBinaryLength();

            Assert.AreEqual(gap, longestGap);
        }

        [TestMethod]
        //[DataRow(9, 2)]
        [DataRow(10, 1)]
        public void GetLongestBinaryLengthA(int integer, int gap)
        {
            BinaryGapCode.Solution binaryGap = new BinaryGapCode.Solution();
            int longestGap = binaryGap.solution(integer);

            Assert.AreEqual(gap, longestGap);
        }
    }
}
