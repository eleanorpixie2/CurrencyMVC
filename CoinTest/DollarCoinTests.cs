using CurrencyMVC.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CoinTest
{
    [TestClass]
    public class DollarCoinTests
    {

        [TestMethod]
        public void DollarCoinConstructor()
        {
            //Arrange
            DollarCoin d, philiDollarCoin;
            //Act 
            d = new DollarCoin();
            philiDollarCoin = new DollarCoin(USCoinMintMark.P);
            //Assert
            //D is the default mint mark
            //Current Year is default year

            Assert.AreEqual(USCoinMintMark.P, philiDollarCoin.MintMark);
        }

        [TestMethod]
        public void DollarCoinMonetaryValue()
        {
            //Arrange
            DollarCoin d;
            //Act 
            d = new DollarCoin();
            //Assert
            Assert.AreEqual(1, d.MonetaryValue);
        }

        [TestMethod]
        public void DollarCoinAbout()
        {
            //Arrange
            DollarCoin d;
            //Act 
            d = new DollarCoin();
            //Assert
            //About output "US Dollar Coin is from 2017. It is worth $1.00. It was made in Denver"
            Assert.AreEqual("US Dollar Coin is from 2019. It is worth $1.00. It was made in Denver", d.About());
        }
    }
}