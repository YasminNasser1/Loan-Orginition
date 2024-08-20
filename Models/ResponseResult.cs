
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loan_Orginition.Models
{
    public class ResponseResult
    {
        public string success { get; set; }

        public JArray Result { get; set; }
        public string message { get; set; }
    }
}