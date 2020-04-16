using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc2DemoDay1.Services
{
    public class TaxCalculatorUK : ITaxCalculator
    {
        public decimal GetTaxRate(decimal monthlySalary)
        {
            return 25;
        }

        public bool SupportsCountry(string country)
        {
            return country == "UK";
        }
    }
}
