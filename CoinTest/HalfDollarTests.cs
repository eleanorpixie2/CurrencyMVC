using CurrencyMVC.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CoinTest
{
    [TestClass]
    public class HalfDollarTests
    {

        [TestMethod]
        public void HalfDollarConstructor()
        {
            //Arrange
            HalfDollar p, philiHalfDollar;
            //Act 
            p = new HalfDollar();
            philiHalfDollar = new HalfDollar(USCoinMintMark.P);
            //Assert
            //D is the default mint mark
            //Current Year is default year

            Assert.AreEqual(USCoinMintMark.P, philiHalfDollar.MintMark);
        }

        [TestMethod]
        public void HalfDollarMonetaryValue()
        {
            //Arrange
            HalfDollar p;
            //Act 
            p = new HalfDollar();
            //Assert
            Assert.AreEqual(.50, p.MonetaryValue);
        }

        [TestMethod]
        public void HalfDollarAbout()
        {
            //Arrange
            HalfDollar p;
            //Act 
            p = new HalfDollar();
            //Assert
            //About output "US Half Dollar is from 2017. It is worth $0.50. It was made in Denver"
            Assert.AreEqual("US Half Dollar is from 2019. It is worth $0.50. It was made in Denver", p.About());
        }
    }
}