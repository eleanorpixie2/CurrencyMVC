using CurrencyMVC.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CoinTest
{
    [TestClass]
    public class DimeTests
    {

        [TestMethod]
        public void DimeConstructor()
        {
            //Arrange
            Dime p, philiDime;
            //Act 
            p = new Dime();
            philiDime = new Dime(USCoinMintMark.P);
            //Assert
            //D is the default mint mark
            //Current Year is default year

            Assert.AreEqual(USCoinMintMark.P, philiDime.MintMark);
        }

        [TestMethod]
        public void DimeMonetaryValue()
        {
            //Arrange
            Dime p;
            //Act 
            p = new Dime();
            //Assert
            Assert.AreEqual(.10, p.MonetaryValue);
        }

        [TestMethod]
        public void DimeAbout()
        {
            //Arrange
            Dime p;
            //Act 
            p = new Dime();
            //Assert
            //About output "US Dime is from 2017. It is worth $0.10. It was made in Denver"
            Assert.AreEqual("US Dime is from 2019. It is worth $0.10. It was made in Denver", p.About());
        }
    }
}