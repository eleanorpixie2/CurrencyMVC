using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyMVC.Models
{
    //coin interface
    public interface ICoin:ICurrency
    {
        //return the year
        int Year { get; }
    }
}
