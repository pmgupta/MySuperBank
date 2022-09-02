using BankyStuffLibrary;
using System;
using Xunit;

namespace BankingTests
{
    public class BasicTests
    {
        [Fact]
        public void TrueIsTrue()
        {
            Assert.True(true);
        }

        [Fact]
        public void CantTakeMoreThanYouHave()
        {
            var account = new BankAccount("Shashank", 1000);

            // Test for a negative balance.

            Assert.Throws<InvalidOperationException>(() => account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw"));

            //// Test that the initial balances must be positive.
            //BankAccount invalidAccount;
            //try
            //{
            //    invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //    return;
            //}
        }


        [Fact]
        public void NeedMoneyToStart()
        {
            var account = new BankAccount("Shashank", 1000);

            // Test that the initial balances must be positive.
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new BankAccount("invalid", -55)
                );
        }

    }
}
