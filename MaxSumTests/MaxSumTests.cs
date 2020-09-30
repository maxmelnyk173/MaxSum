using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaxSum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaxSum.Tests
{
    [TestClass()]
    public class MaxSumTests
    {
        [TestMethod()]
        public void MaxArrayIndexTest()
        {
            var strArray = new NumberOfRow()
            {
                StrArray = new[] { "1,a,3,5", "2,4.9,7", "5,3,8.0" }
            };

            Assert.AreEqual(1, strArray.MaxArrayNumber());
        }
    }
}