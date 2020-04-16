﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc2DemoDay1.Services
{
    public interface ITaxCalculator
    {
        decimal GetTaxRate(decimal monthlySalary);
        bool SupportsCountry(string country);
    }
}
