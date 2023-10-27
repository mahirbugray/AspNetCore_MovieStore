using AspNetCoreMvc_MovieSales.Data;
using AspNetCoreMvc_MovieSales.Interfaces;
using AspNetCoreMvc_MovieSales.Models;

namespace AspNetCoreMvc_MovieSales.Repositories
{
    public class MovieSaleDetailRepository : IMovieSaleDetailRepository
    {
        private readonly MovieDbContext _context;
        public MovieSaleDetailRepository(MovieDbContext context)
        {
            _context = context;
        }
        public void Add(MovieSaleDetail movieSaleDetail)
        {
            _context.MovieSaleDetails.Add(movieSaleDetail); //ara katmana ekler.
            _context.SaveChanges(); //veritabanıyla eşleştirir.
        }

        public bool AddRange(List<SepetDetay> sepet, int movieSaleId)
        {
            foreach (var item in sepet)
            {
                MovieSaleDetail newDetail = new MovieSaleDetail()
                {
                    MovieSaleId = movieSaleId,
                    MovieId = item.MovieId,
                    Number = item.MovieQuantity,
                    UnitPrice = item.MoviePrice
                };
                _context.MovieSaleDetails.Add(newDetail);  //ara katmana kayıt edilirler.
            }
            try
            {
                _context.SaveChanges(); //Veritabanına hepsini birden gönderiyoruz.
                return true;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return false;
        }

        public List<MovieSaleDetail> GetAll()
        {
            return _context.MovieSaleDetails.ToList();
        }
    }
}
