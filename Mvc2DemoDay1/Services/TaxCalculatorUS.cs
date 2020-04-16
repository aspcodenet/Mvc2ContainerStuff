using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc2DemoDay1.Services
{
    public class TaxCalculatorUS : ITaxCalculator
    {
        public decimal GetTaxRate(decimal monthlySalary)
        {
            return 30;
        }
        public bool SupportsCountry(string country)
        {
            return country == "US";
        }

    }


    public class TaxCalculatorSE : ITaxCalculator
    {
        public decimal GetTaxRate(decimal monthlySalary)
        {
            //hjkhdahjkjkldasds 
            //dashjas

            return 10;
        }
        public bool SupportsCountry(string country)
        {
            return country == "SE";
        }

    }


}

