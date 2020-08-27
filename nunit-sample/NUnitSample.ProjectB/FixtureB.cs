using NUnit.Framework;

namespace NUnitSample.ProjectB
{
    [TestFixture]
    public class FixtureB
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