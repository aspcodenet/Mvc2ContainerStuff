using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc2DemoDay1.Services
{
    public class RateService : IRateService
    {
        public decimal GetRate()
        {
            return 12;
        }
    }
}
