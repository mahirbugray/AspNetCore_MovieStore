using AspNetCoreMvc_MovieSales.Data;
using AspNetCoreMvc_MovieSales.Interfaces;
using AspNetCoreMvc_MovieSales.Models;

namespace AspNetCoreMvc_MovieSales.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly MovieDbContext _context;
        public GenreRepository(MovieDbContext context)
        {
            _context = context;
        }
        public void Add(Genre genre)
        {
            _context.Genres.Add(genre); //ara katmana ekler.
            _context.SaveChanges(); //veritabanıyla eşleştirir.
        }
        public void Delete(Genre genre)
        {
            _context.Genres.Remove(genre);
            _context.SaveChanges();
        }
        public List<Genre> GetAll()
        {
            return _context.Genres.ToList();
        }
        public Genre GetById(int id)
        {
            return _context.Genres.Find(id);
        }
        public void Update(Genre genre)
        {
            _context.Genres.Update(genre);
            _context.SaveChanges();
        }
    }
}
