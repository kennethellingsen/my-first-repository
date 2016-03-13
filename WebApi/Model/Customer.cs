using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace WebApi.Model
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobilephone { get; set; }
    }
}