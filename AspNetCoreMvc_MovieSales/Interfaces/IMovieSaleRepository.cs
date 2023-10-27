using AspNetCoreMvc_MovieSales.Models;

namespace AspNetCoreMvc_MovieSales.Interfaces
{
    public interface IMovieSaleRepository
    {
        public List<MovieSale> GetAll();
        public void Add(MovieSale movieSale);
        public int AddSale(MovieSale movieSale);
    }
}
