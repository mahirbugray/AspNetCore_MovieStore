namespace AspNetCoreMvc_MovieSales.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Navigation Property (Relation)
        public List<Movie> Movies { get; set; }
    }
}
