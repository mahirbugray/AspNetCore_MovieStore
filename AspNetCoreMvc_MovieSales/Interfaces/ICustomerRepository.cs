using AspNetCoreMvc_MovieSales.Models;

namespace AspNetCoreMvc_MovieSales.Interfaces
{
    public interface ICustomerRepository
    {
        public List<Customer> GetAll();
        public Customer GetById(int id);
        public void Add(Customer customer);
        public void Update(Customer customer);
        public void Delete(Customer customer);
    }
}
