using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChiangmaiXamarin.Library;
using Microsoft.AspNetCore.Mvc;

namespace ChiangmaiXamarin.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            var customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, Name = "Bond" });
            customers.Add(new Customer { Id = 2, Name = "Piti" });
            customers.Add(new Customer { Id = 3, Name = "Jammy" });

            return customers;
        }
    }
}
