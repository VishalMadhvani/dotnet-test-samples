using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestSample.ProjectB
{
    [TestClass]
    public class ClassA
    {
        [TestMethod]
        public void PassingTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void FailingTest()
        {
            Assert.IsTrue(false);
        }
    }
}
