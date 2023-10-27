using AspNetCoreMvc_MovieSales.Data;
using AspNetCoreMvc_MovieSales.Interfaces;
using AspNetCoreMvc_MovieSales.Models;

namespace AspNetCoreMvc_MovieSales.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDbContext _context;
        public MovieRepository(MovieDbContext context)
        {
            _context = context;
        }
        public void Add(Movie movie)
        {
            _context.Movies.Add(movie); //ara katmana ekler.
            _context.SaveChanges(); //veritabanıyla eşleştirir.
        }
        public void Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }
        public List<Movie> GetAll()
        {
            return _context.Movies.ToList();
        }
        public Movie GetById(int id)
        {
            return _context.Movies.Find(id);
        }
        public void Update(Movie movie)
        {
            _context.Movies.Update(movie);
            _context.SaveChanges();
        }

    }
}
