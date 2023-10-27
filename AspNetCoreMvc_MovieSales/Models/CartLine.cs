namespace AspNetCoreMvc_MovieSales.Models
{
    public class CartLine
    {
        public int MovieId { get; set; }
        public int Number { get; set; }
        public decimal UnitPrice { get; set; }

        public int CartId { get; set; }
        public Cart Cart { get; set; }

    }
}
