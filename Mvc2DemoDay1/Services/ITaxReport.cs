using Mvc2DemoDay1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc2DemoDay1.Services
{
    public interface ITaxReport
    {
        void GenerateReport(IEnumerable<Employees> employees);
    }
}
