using NUnit.Framework;

namespace nunit_sample
{
    [TestFixture]
    public class FixtureA
    {
        [Test]
        public void PassingTest()
        {
            Assert.Pass();
        }

        [Test]
        public void FailingTest()
        {
            Assert.Fail();
        }
    }
}
