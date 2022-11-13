using NUnit.Framework;
using DemoModul5;

namespace TestDemo
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void AccountInitializedWithPositiveValue()
        {
            BankAccount bankAcc = new BankAccount(100);
            Assert.AreEqual(100, bankAcc.Balance);
        }
        [Test]
        public void DepositAddsMoney()
        {   //Arange
            BankAccount bankAcc = new BankAccount(100);

            //Act
            bankAcc.Deposit(50);

            //Assert
            Assert.AreEqual(150, bankAcc.Balance);
        }
    }
}