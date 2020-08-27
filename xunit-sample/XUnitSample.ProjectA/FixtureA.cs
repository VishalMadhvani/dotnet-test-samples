using Xunit;

namespace XUnitSample.ProjectA
{
    public class FixtureA
    {
        [Fact]
        public void PassingTest()
        {
            Assert.True(true);
        }

        [Fact]
        public void FailingTest()
        {
            Assert.True(false);
        }
    }
}