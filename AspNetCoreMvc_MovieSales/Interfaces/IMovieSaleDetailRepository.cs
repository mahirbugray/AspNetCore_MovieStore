using AspNetCoreMvc_MovieSales.Models;

namespace AspNetCoreMvc_MovieSales.Interfaces
{
    public interface IMovieSaleDetailRepository
    {
        public List<MovieSaleDetail> GetAll();
        public void Add(MovieSaleDetail movieSaleDetail);
        public bool AddRange(List<SepetDetay> sepet, int movieSaleId);
    }
}
