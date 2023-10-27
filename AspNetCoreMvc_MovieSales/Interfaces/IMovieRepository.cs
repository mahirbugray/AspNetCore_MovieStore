using AspNetCoreMvc_MovieSales.Models;

namespace AspNetCoreMvc_MovieSales.Interfaces
{
    public interface IMovieRepository
    {
        public List<Movie> GetAll();
        public Movie GetById(int id);
        public void Add(Movie movie);
        public void Update(Movie movie);
        public void Delete(Movie movie);
    }
}
