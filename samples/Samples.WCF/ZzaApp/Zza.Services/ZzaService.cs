namespace Zza.Services
{
    using System.Collections.Generic;
    using Entities;

    public class ZzaService : IZzaService
    {
        readonly ZzaDbContext _Context = new ZzaDbContext();
        public List<Product> GetProducts()
        {
            return _Context.Products.ToList();
        }

        public List<Customer> GetCustomers()
        {
            return _Context.Customers.ToList();
        }

        public void SubmitOrder(Order order)
        {
            _Context.Orders.Add(order);
            order.OrderItems.ForEach(oi => _Context.OrderItems.Add(oi));
            _Context.SaveChanges();
        }
    }
}
