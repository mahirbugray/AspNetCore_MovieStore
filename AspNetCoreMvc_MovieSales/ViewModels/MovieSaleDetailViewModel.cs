namespace AspNetCoreMvc_MovieSales.ViewModels
{
    public class MovieSaleDetailViewModel
    {
        public int Id { get; set; }
        public int MovieSaleId { get; set; }
        public int MovieId { get; set; }
        public int Number { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
