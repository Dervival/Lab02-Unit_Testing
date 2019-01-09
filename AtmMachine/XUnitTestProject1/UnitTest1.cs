using System;
using Xunit;
using AtmMachine;

namespace AtmXUnitTests
{
    public class AtmXUnitTests
    {
        [Fact]
        public void WithdrawFromAccountChangesBalance()
        {
            //arrange
            Program.balance = 200.00M;
            //act
            Program.Withdraw(100.00M);
            //assert
            Assert.Equal(100.00M, Program.balance);
        }
        [Fact]
        public void WithdrawalRejectsOverdrafts()
        {
            //arrange
            Program.balance = 100.00M;
            //act
            Program.Withdraw(200.00M);
            //assert
            Assert.Equal(100.00M, Program.balance);
        }
        [Fact]
        public void WithdrawalRejectsNegativeInput()
        {
            //arrange
            Program.balance = 100.00M;
            //act
            Program.Withdraw(-50.00M);
            //assert
            Assert.Equal(100.00M, Program.balance);
        }
    }
}
