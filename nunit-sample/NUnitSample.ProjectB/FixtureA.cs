using NUnit.Framework;

namespace NUnitSample.ProjectB
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