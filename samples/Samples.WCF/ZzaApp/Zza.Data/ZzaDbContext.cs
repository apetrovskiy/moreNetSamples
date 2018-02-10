namespace Zza.Data
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using Entities;

    public class ZzaDbContext : DbContext
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
    }
}
