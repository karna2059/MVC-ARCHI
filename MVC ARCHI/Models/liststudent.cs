using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_ARCHI.Models
{
    public class student
    {
        public int studentid { get; set; }

        public string name { get; set; }

        public int age { get; set; }

        public string email { get; set; }

        public DateTime EnrollmentDate { get; set; }
    }
}