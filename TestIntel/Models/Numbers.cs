using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestIntel.Models
{
    public class Numbers
    {
        [Range(1,1000, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Number { get; set; }

        public string Type { get; set; }
    }
}