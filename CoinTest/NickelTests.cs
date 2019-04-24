using CurrencyMVC.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CoinTest
{
    [TestClass]
    public class NickelTests
    {

        [TestMethod]
        public void NickelConstructor()
        {
            //Arrange
            Nickel p, philiNickel;
            //Act 
            p = new Nickel();
            philiNickel = new Nickel(USCoinMintMark.P);
            //Assert
            //D is the default mint mark
            //Current Year is default year

            Assert.AreEqual(USCoinMintMark.P, philiNickel.MintMark);
        }

        [TestMethod]
        public void NickelMonetaryValue()
        {
            //Arrange
            Nickel p;
            //Act 
            p = new Nickel();
            //Assert
            Assert.AreEqual(.05, p.MonetaryValue);
        }

        [TestMethod]
        public void NickelAbout()
        {
            //Arrange
            Nickel p;
            //Act 
            p = new Nickel();
            //Assert
            //About output "US Nickel is from 2017. It is worth $0.05. It was made in Denver"
            Assert.AreEqual("US Nickel is from 2019. It is worth $0.05. It was made in Denver", p.About());
        }
    }
}