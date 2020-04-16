using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc2DemoDay1.Services
{
    public class CachedRateService : IRateService
    {
        public CachedRateService(IRateService backingStore)
        {
            this.backingStore = backingStore;
        }
        private decimal d = -1;
        private readonly IRateService backingStore;

        public decimal GetRate()
        {
            if (d == -1)
                d = backingStore.GetRate();
            return d;
        }
    }
}
