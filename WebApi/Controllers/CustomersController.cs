using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.ServiceModel.Security.Tokens;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class CustomersController : ApiController
    {
        private static List<Customer> customers = new List<Customer>
        {
            new Customer { Name = "John Doe" },
            new Customer { Name = "Nancy Davolo" }
        };

        // GET api/customers
        //[Authorize]
        public IEnumerable<Customer> Get()
        {
            return customers.ToArray();
        }

        // POST api/customers
        //[Authorize]
        public Customer Post(Customer name)
        {
            customers.Add(name);
            return name;
        }
    }

    public class Customer
    {
        public string Name { get; set; }
    }
}
