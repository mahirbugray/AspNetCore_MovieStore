namespace AspNetCoreMvc_MovieSales.Models
{
    public class MovieSaleDetail
    {
        public int Id { get; set; }
        public int MovieSaleId { get; set; }
        public int MovieId { get; set; }
        public int Number { get; set; }
        public decimal UnitPrice { get; set; }

        public MovieSale MovieSale { get; set; }
        public Movie Movie { get; set; }
    }
}
