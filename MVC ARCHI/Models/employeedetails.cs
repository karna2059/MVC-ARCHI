using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_ARCHI.Models
{
    public class employeedetails
    {
        public int empoyeeid { get; set; }

        public string name { get; set; }

        public long phone { get; set; }

        public string email { get; set; }

        public decimal salary { get; set; }
    }
}