namespace AspNetCoreMvc_MovieSales.ViewModels
{
    public class MovieSaleViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
