using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loan_Orginition.Models
{
    public class Address
    {
        public string Country { get; set; }
        public CustomerCity City { get; set; } //Option Menu
        public string Area { get; set; }
        public string Street { get; set; }
    }
}