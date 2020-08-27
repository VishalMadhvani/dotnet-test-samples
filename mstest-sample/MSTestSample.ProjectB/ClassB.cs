using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestSample.ProjectB
{
    [TestClass]
    public class ClassB
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
