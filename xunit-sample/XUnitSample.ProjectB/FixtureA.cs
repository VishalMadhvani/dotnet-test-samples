using Xunit;

namespace XUnitSample.ProjectB
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