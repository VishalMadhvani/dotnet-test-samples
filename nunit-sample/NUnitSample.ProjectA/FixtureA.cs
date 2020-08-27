using NUnit.Framework;

namespace NUnitSample.ProjectA
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