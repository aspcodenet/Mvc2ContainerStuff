using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc2DemoDay1.ViewModels
{
    public class ValidationDemoViewModel
    {
        [Required]
        public string Name { get; set; }
        public string CreditCardNumber { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
    }
}
