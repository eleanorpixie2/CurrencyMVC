using CurrencyMVC.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CoinTest
{
    [TestClass]
    public class QuarterTests
    {

        [TestMethod]
        public void QuarterConstructor()
        {
            //Arrange
            Quarter p, philiQuarter;
            //Act 
            p = new Quarter();
            philiQuarter = new Quarter(USCoinMintMark.P);
            //Assert
            //D is the default mint mark
            //Current Year is default year

            Assert.AreEqual(USCoinMintMark.P, philiQuarter.MintMark);
        }

        [TestMethod]
        public void QuarterMonetaryValue()
        {
            //Arrange
            Quarter p;
            //Act 
            p = new Quarter();
            //Assert
            Assert.AreEqual(0.25, p.MonetaryValue);
        }

        [TestMethod]
        public void QuarterAbout()
        {
            //Arrange
            Quarter p;
            //Act 
            p = new Quarter();
            //Assert
            //About output "US Quarter is from 2017. It is worth $0.25. It was made in Denver"
            Assert.AreEqual("US Quarter is from 2019. It is worth $0.25. It was made in Denver", p.About());
        }
    }
}