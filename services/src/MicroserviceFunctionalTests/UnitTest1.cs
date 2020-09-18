namespace MicroserviceFunctionalTests
{
    using System;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(5, 5);
        }

        [Fact]
        public void Test2() {
            Assert.Equal(5, 5);
        }

        [Fact]
        public void Test3() {
            Assert.Equal(5, 5);
        }
    }
}