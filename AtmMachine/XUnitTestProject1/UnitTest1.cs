using System;
using Xunit;
using AtmMachine;

namespace AtmXUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string[] arguments = { };
            Program.Main(arguments);
            Assert.Equal(1, 1);
        }
    }
}
