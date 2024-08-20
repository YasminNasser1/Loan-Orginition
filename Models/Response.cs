using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loan_Orginition.Models
{
    public class Response
    {
        public string Success { get; set; }
        public JObject Result { get; set; }
        public string Massage { get; set; }
    }
}