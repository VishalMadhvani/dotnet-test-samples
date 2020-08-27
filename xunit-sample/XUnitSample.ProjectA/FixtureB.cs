using Xunit;

namespace XUnitSample.ProjectA
{
    public class FixtureB
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