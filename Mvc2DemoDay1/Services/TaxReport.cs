using Mvc2DemoDay1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc2DemoDay1.Services
{
    public class TaxReport : ITaxReport
    {
        private readonly ITaxCalculator[] taxCalculators;

        public TaxReport(IEnumerable<ITaxCalculator> taxCalculators)
        {
            this.taxCalculators = taxCalculators.ToArray();
        }
        public void GenerateReport(IEnumerable<Employees> employees)
        {
            foreach(var employee in employees)
            {
                var calc = GetTaxCalculator(employee.Country);
                decimal rate = calc.GetTaxRate(10000);
            }
        }
        private ITaxCalculator GetTaxCalculator(string country)
        {
            return this.taxCalculators.First(s => s.SupportsCountry(country));
        }
    }
}
