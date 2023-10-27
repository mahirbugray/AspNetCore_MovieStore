using AspNetCoreMvc_MovieSales.Data;
using AspNetCoreMvc_MovieSales.Interfaces;
using AspNetCoreMvc_MovieSales.Models;

namespace AspNetCoreMvc_MovieSales.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly MovieDbContext _context;
        public CustomerRepository(MovieDbContext context)
        {
            _context = context;
        }
        public void Add(Customer customer)
        {
            _context.Customers.Add(customer); //ara katmana ekler.
            _context.SaveChanges(); //veritabanıyla eşleştirir.
        }
        public void Delete(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
        public List<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }
        public Customer GetById(int id)
        {
            return _context.Customers.Find(id);
        }
        public void Update(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }
    }
}
