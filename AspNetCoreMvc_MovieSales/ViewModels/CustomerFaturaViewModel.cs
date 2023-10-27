using AspNetCoreMvc_MovieSales.Models;

namespace AspNetCoreMvc_MovieSales.ViewModels
{
    public class CustomerFaturaViewModel
    {
        public CustomerViewModel customerViewModel { get; set; }
        public MovieSaleViewModel satisViewModel { get; set; }

        public List<SepetDetay> sepetDetayListesi { get; set; }
    }
}
