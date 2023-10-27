using AspNetCoreMvc_MovieSales.Data;
using AspNetCoreMvc_MovieSales.Interfaces;
using AspNetCoreMvc_MovieSales.Models;

namespace AspNetCoreMvc_MovieSales.Repositories
{
    public class MovieSaleRepository : IMovieSaleRepository
    {
        private readonly MovieDbContext _context;
        public MovieSaleRepository(MovieDbContext context)
        {
            _context = context;
        }

        public void Add(MovieSale movieSale)
        {
            _context.MovieSales.Add(movieSale); //ara katmana ekler.
            _context.SaveChanges(); //veritabanıyla eşleştirir.
        }

        public int AddSale(MovieSale movieSale)
        {
            _context.MovieSales.Add(movieSale); //ara katmana ekler.
            _context.SaveChanges(); //veritabanıyla eşleştirir.
            return movieSale.Id;
        }

        public List<MovieSale> GetAll()
        {
            return _context.MovieSales.ToList();
        }
    }
}
