using System;
using Northwind.Data;
using Northwind.Data.Models;

namespace Northwind.Infrastructure.Repositories
{
    public class CustomerRepository : BaseRepository<Customer, NorthwindContext>
    {
        public CustomerRepository(NorthwindContext context)
            : base(context)
        {

        }
    }
}
