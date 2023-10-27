namespace AspNetCoreMvc_MovieSales.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public string Cast { get; set; }
        public string Summary { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool IsLocal { get; set; }
        public bool IsPopuler { get; set; }
        public bool IsDiscount { get; set; }
        public int GenreId { get; set; }

        //Navigation Property (Relation)
        public Genre Genre { get; set; }
        public List<MovieSaleDetail> MovieSaleDetails { get; set; }

    }
}
