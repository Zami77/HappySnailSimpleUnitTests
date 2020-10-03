using HappySnailSimpleMath;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HappySnailSimpleUnitTests
{
    [TestClass]
    public class SimpleUnitTests
    {
        [TestMethod]
        public void TestAddNums()
        {
            //Ints
            Assert.AreEqual(SimpleMath.AddNums(2, 3), 5);
            Assert.AreEqual(SimpleMath.AddNums(0, 0), 0);
            Assert.AreEqual(SimpleMath.AddNums(0, -1), -1);
            Assert.AreEqual(SimpleMath.AddNums(-1, -1), -2);

            //Doubles
            Assert.AreEqual(SimpleMath.AddNums(.5, .2), .7);
        }
        [TestMethod]
        public void TestDivideNums()
        {
            Assert.AreEqual(SimpleMath.DivideNums(5.0, 2.5), 2.0);
            Assert.AreEqual(SimpleMath.DivideNums(-5.0, 2.5), -2.0);
            Assert.AreEqual(SimpleMath.DivideNums(5.0, -2.5), -2.0);
        }
        [TestMethod]
        public void TestIsPrimeNum()
        {
            Assert.IsTrue(SimpleMath.IsPrime(2));
            Assert.IsTrue(SimpleMath.IsPrime(3));
            Assert.IsTrue(SimpleMath.IsPrime(5));
            Assert.IsTrue(SimpleMath.IsPrime(7));
            Assert.IsTrue(SimpleMath.IsPrime(11));

            Assert.IsFalse(SimpleMath.IsPrime(4));
        }
    }
}
