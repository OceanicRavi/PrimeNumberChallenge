using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumberChallenge;

namespace TestPrimeNumberChallenge
{
    [TestClass]
    public class TestFindNumber
    {
        [TestMethod]
        public void Test_CheckProductCriteria()
        {
            FindNumber findNumber = new FindNumber();
            bool check1 = findNumber.CheckProductCriteria(123345678999999);
            Assert.IsTrue(check1);
            bool check2 = findNumber.CheckProductCriteria(1134444556666777);
            Assert.IsFalse(check2);
            bool check3 = findNumber.CheckProductCriteria(9998887655543321);
            Assert.IsFalse(check3);
            bool check4 = findNumber.CheckProductCriteria(123334444567);
            Assert.IsTrue(check4);
        }
    }
}
