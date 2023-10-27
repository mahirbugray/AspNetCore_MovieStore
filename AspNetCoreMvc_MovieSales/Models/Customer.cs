namespace AspNetCoreMvc_MovieSales.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        //Navigation Property (Relation)
        public List<MovieSale> MovieSales { get; set; }
    }
}
