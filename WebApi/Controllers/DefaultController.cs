using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Model;

namespace WebApi.Controllers
{
    public class DefaultController : ApiController
    {
        [Route ("api/customers")]
        public IHttpActionResult Get()
        {
            IList<Customer> customers = new List<Customer>();
            customers.Add(new Customer() { Name = "Nice customer", Email = "nice@aol.com", Mobilephone = "123345456" });
            customers.Add(new Customer() { Name = "Good customer", Email = "good@online.co.uk", Mobilephone = "9878757654" });
            customers.Add(new Customer() { Name = "Awesome customer", Email = "awsome@telekom.de", Mobilephone = "34546456" });
            return Ok(customers);
        }
    }
}
