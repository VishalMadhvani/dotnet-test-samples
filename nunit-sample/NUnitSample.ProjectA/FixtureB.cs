using NUnit.Framework;

namespace NUnitSample.ProjectA
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