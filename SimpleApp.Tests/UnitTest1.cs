using Xunit;
using SimpleApp;

namespace SimpleApp.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void AddNumbers_ShouldReturnCorrectSum()
        {
            int result = Program.AddNumbers(5, 7);
            Assert.Equal(12, result);
        }

        [Fact]
        public void AddNumbers_ShouldHandleNegativeNumbers()
        {
            int result = Program.AddNumbers(-3, 7);
            Assert.Equal(4, result);
        }
    }
}
//asdasd