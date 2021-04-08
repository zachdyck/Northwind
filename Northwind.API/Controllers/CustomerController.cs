using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly Northwind.Infrastructure.Repositories.CustomerRepository _customerRepository;

        public CustomerController(ILogger<CustomerController> logger,
            Northwind.Infrastructure.Repositories.CustomerRepository customerRepository)
        {
            _logger = logger;
            _customerRepository = customerRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Northwind.Data.Models.Customer>> Get()
        {
            return await _customerRepository.GetAll();
        }
    }
}
